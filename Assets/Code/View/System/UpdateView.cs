using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class UpdateView :
        MonoBehaviour
    {
        #region Fields

        private UpdateController _controller;

        #endregion


        #region Methods

        public void Initialize(UpdateController controller) => _controller = controller;

        #endregion


        #region UnityMethods

        private void Update() => _controller.LogicUpdate();

        private void FixedUpdate() => _controller.PhysicsUpdate();

        private void LateUpdate() => _controller.LateUpdate();

        #endregion
    }
}
