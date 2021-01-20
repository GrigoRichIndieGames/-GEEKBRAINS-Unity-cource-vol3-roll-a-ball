using System.Collections.Generic;


namespace GeekbrainsStudy
{
    internal sealed class UpdateControllerModel
    {
        #region Fields

        private readonly List<ILogicUpdatable> _iUpdatables;
        private readonly List<IPhysicsUpdatable> _iFixedUpdatables;
        private readonly List<ILateUpdatable> _iLateUpdatables;

        #endregion


        #region Properties

        public List<ILogicUpdatable> ILogicUpdatables => _iUpdatables;
        public List<IPhysicsUpdatable> IPhysicsUpdatables => _iFixedUpdatables;
        public List<ILateUpdatable> ILateUpdatables => _iLateUpdatables;

        #endregion


        #region ClassicLifeCycle

        internal UpdateControllerModel()
        {
            _iUpdatables = new List<ILogicUpdatable>();
            _iFixedUpdatables = new List<IPhysicsUpdatable>();
            _iLateUpdatables = new List<ILateUpdatable>();
        }

        #endregion
    }
}
