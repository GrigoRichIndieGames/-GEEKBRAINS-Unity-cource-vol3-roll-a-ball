using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class PlayerControllerView :
        MonoBehaviour
    {
        #region Fields

        private PlayerController _controller;

        #endregion


        #region Methods

        public void Initialize(PlayerController controller)
        {
            _controller = controller;
        }

        #endregion


        #region UnityMethods

        private void OnTriggerEnter(Collider other)
        {
            IInteractable interactable;
            other.TryGetComponent<IInteractable>(out interactable);

            if (interactable != null)
                switch (interactable)
                {
                    case IBuff buff:
                        buff.Interact(_controller);
                        break;
                    default:
                        break;
                }
        }

        #endregion
    }
}
