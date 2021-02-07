using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class PlayerView :
        MonoBehaviour
    {
        #region Fields

        private PlayerController _controller;

        #endregion


        #region Methods

        public void Initialize(PlayerController controller) => _controller = controller;

        #endregion


        #region UnityMethods

        private void OnTriggerEnter(Collider other) => _controller.Interact(other);

        #endregion
    }
}
