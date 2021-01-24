namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class UpdateController :
        IController
    {
        #region Fields

        private UpdateModel _model;

        #endregion


        #region ClassicLifeCycle

        internal UpdateController()
        {
            _model = new UpdateModel();
        }

        #endregion


        #region Methods

        internal void Register(object updatable)
        {
            if (updatable is ILogicUpdatable)
                _model.ILogicUpdatables.Add(updatable as ILogicUpdatable);
            if (updatable is IPhysicsUpdatable)
                _model.IPhysicsUpdatables.Add(updatable as IPhysicsUpdatable);
            if (updatable is ILateUpdatable)
                _model.ILateUpdatables.Add(updatable as ILateUpdatable);
        }

        internal void Unregister(object updatable)
        {
            if (updatable is ILogicUpdatable)
                _model.ILogicUpdatables.Remove(updatable as ILogicUpdatable);
            if (updatable is IPhysicsUpdatable)
                _model.IPhysicsUpdatables.Remove(updatable as IPhysicsUpdatable);
            if (updatable is ILateUpdatable)
                _model.ILateUpdatables.Remove(updatable as ILateUpdatable);
        }

        internal void LogicUpdate()
        {
            var count = _model.ILogicUpdatables.Count;
            for (int i = 0; i < count; i++)
            {
                _model.ILogicUpdatables[i].LogicUpdate();
            }
        }

        internal void PhysicsUpdate()
        {
            var count = _model.IPhysicsUpdatables.Count;
            for (int i = 0; i < count; i++)
            {
                _model.IPhysicsUpdatables[i].PhysicsUpdate();
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
