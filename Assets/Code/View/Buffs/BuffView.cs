using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    class BuffView :
        MonoBehaviour,
        IBuff
    {
        #region Fields

        private IBuffController _controller;

        #endregion


        #region Methods

        public void Initial(IBuffController controller) => _controller = controller;

        #endregion


        #region Methods

        public void Interact(PlayerModel model) => _controller.SetBuff(model);

        #endregion
    }
}
