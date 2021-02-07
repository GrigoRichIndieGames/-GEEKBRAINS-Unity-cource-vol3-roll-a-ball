using UnityEngine;
using UnityEngine.EventSystems;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class VirtualJoystickView :
        MonoBehaviour,
        IPointerDownHandler,
        IDragHandler,
        IPointerUpHandler
    {
        #region Fields

        [SerializeField] private RectTransform _background;
        [SerializeField] private RectTransform _stick;

        [SerializeField] private float _stickRange;
        [SerializeField] private float _deadZone;

        private Vector2 _input;

        #endregion


        #region Properties

        public float HorizontalAxis => _input.x;

        #endregion


        #region UnityMethods

        private void Start()
        {
            var center = new Vector2(0.5f, 0.5f);
            _background.pivot = center;
            _stick.pivot = center;
            _stick.anchorMin = center;
            _stick.anchorMax = center;
            _stick.anchoredPosition = Vector2.zero;
        }

        #endregion


        #region Interfaces

        public void OnPointerDown(PointerEventData touch)
        {
            OnDrag(touch);
        }

        public void OnDrag(PointerEventData touch)
        {
            var position = (Vector2)_background.position;
            var radius = _background.sizeDelta / 2;
            _input = (touch.position - position) / radius;

            var magnitude = _input.magnitude;
            if (magnitude > _deadZone)
            {
                if (magnitude > 1) _input = _input.normalized;
            }
            else
            {
                _input = Vector2.zero;
            }

            _stick.anchoredPosition = _input * radius * _stickRange;
        }

        public void OnPointerUp(PointerEventData touch)
        {
            _input = Vector2.zero;
            _stick.anchoredPosition = Vector2.zero;
        }

        #endregion
    }
}
