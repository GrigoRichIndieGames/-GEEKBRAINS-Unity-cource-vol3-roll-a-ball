using System.Collections.Generic;


namespace GeekbrainsStudy
{
    internal sealed class UpdateControllerModel
    {
        #region Fields

        private readonly List<IUpdatable> _iUpdatables;
        private readonly List<IFixedUpdatable> _iFixedUpdatables;
        private readonly List<ILateUpdatable> _iLateUpdatables;

        #endregion


        #region Properties

        public List<IUpdatable> IUpdatables => _iUpdatables;
        public List<IFixedUpdatable> IFixedUpdatables => _iFixedUpdatables;
        public List<ILateUpdatable> ILateUpdatables => _iLateUpdatables;

        #endregion


        #region ClassicLifeCycle

        internal UpdateControllerModel()
        {
            _iUpdatables = new List<IUpdatable>();
            _iFixedUpdatables = new List<IFixedUpdatable>();
            _iLateUpdatables = new List<ILateUpdatable>();
        }

        #endregion
    }
}
