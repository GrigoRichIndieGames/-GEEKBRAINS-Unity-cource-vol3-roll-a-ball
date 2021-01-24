using UnityEngine;


namespace GeekbrainsStudy
{
    internal abstract class BasePermanentBuffController :
        IController,
        IBuffController,
        IDestroyable
    {
        #region Fields

        protected BuffModel _model;
        protected GameContextLocator _locator;

        #endregion


        #region ClassicLifeCycle

        internal BasePermanentBuffController(BuffData data, GameContextLocator locator)
        {
            _model = new BuffModel(data);
            _locator = locator;
        }

        #endregion


        #region Interfaces

        public virtual void DestroyController(GameObject view)
        {
            Object.Destroy(view);
        }

        public virtual void SetBuff(PlayerModel model)
        {
            _model.PlayerModel = model;
        }

        #endregion
    }
}
