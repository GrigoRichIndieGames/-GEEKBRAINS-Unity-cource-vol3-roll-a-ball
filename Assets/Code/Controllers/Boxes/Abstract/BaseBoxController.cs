using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal abstract class BaseBoxController :
        IController,
        IDestroyable,
        ILogicUpdatable
    {
        #region Fields

        protected BoxModel _model;
        protected GameContextLocator _locator;

        #endregion


        #region ClassicLifeCycle

        internal BaseBoxController(BoxData data, GameContextLocator locator)
        {
            _model = new BoxModel(data);
            _locator = locator;
        }

        #endregion


        #region Methods

        internal void ColliderInteracr(Collider collision)
        {

        }

        internal void SetLevelID(int id)
        {

        }



        #endregion


        #region Interfaces

        public virtual void DestroyController(GameObject view)
        {
            Object.Destroy(view);
        }

        public void LogicUpdate()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
