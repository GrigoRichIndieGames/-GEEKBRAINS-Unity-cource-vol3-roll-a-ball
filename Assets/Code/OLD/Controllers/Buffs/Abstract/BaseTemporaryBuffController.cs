using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal abstract class BaseTemporaryBuffController :
        IController,
        IBuffController,
        IDestroyable
    {
        #region Fields

        protected BuffModel _model;
        protected GameContextLocator _locator;

        #endregion


        #region ClassicLifeCycle

        internal BaseTemporaryBuffController(BuffData data, GameContextLocator locator)
        {
            _model = new BuffModel(data);
            _locator = locator;
        }

        #endregion


        #region Methods

        internal abstract void DeactivateBuff();

        #endregion


        #region Interfaces

        public virtual void DestroyController(GameObject view)
        {
            Object.Destroy(view);
        }

        public virtual void SetBuff(PlayerModel model)
        {
            _model.PlayerModel = model;
            new BuffTimer(DeactivateBuff, _model.TimeOfAction, _locator.Get<UpdateController>());
        }

        #endregion
    }
}
