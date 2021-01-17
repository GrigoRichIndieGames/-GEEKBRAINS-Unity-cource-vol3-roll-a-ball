namespace GeekbrainsStudy
{
    internal sealed class UpdateController : IController
    {
        #region Fields

        private UpdateControllerModel _model;

        #endregion


        #region ClassicLifeCycle

        internal UpdateController()
        {
            _model = new UpdateControllerModel();
        }

        #endregion


        #region Methods

        internal void Register(object updatable)
        {
            if (updatable is IUpdatable)
                _model.IUpdatables.Add(updatable as IUpdatable);
            if (updatable is IFixedUpdatable)
                _model.IFixedUpdatables.Add(updatable as IFixedUpdatable);
            if (updatable is ILateUpdatable)
                _model.ILateUpdatables.Add(updatable as ILateUpdatable);
        }

        internal void Unregister(object updatable)
        {
            if (updatable is IUpdatable)
                _model.IUpdatables.Remove(updatable as IUpdatable);
            if (updatable is IFixedUpdatable)
                _model.IFixedUpdatables.Remove(updatable as IFixedUpdatable);
            if (updatable is ILateUpdatable)
                _model.ILateUpdatables.Remove(updatable as ILateUpdatable);
        }

        internal void LogicUpdate()
        {
            var count = _model.IUpdatables.Count;
            for (int i = 0; i < count; i++)
            {
                _model.IUpdatables[i].LogicUpdate();
            }
        }

        internal void PhysicsUpdate()
        {
            var count = _model.IFixedUpdatables.Count;
            for (int i = 0; i < count; i++)
            {
                _model.IFixedUpdatables[i].PhysicsUpdate();
            }
        }

        internal void LateUpdate()
        {
            var count = _model.ILateUpdatables.Count;
            for (int i = 0; i < count; i++)
            {
                _model.ILateUpdatables[i].LateUpdate();
            }
        }

        #endregion
    }
}
