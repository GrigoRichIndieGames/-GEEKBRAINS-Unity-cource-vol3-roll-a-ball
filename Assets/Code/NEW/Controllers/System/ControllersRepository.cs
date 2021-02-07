using System;
using System.Collections.Generic;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class ControllersRepository :
        IInitializable,
        ILogicUpdatable,
        IPhysicUpdatable,
        ILateUpdatable,
        IDestroyable
    {
        #region Fields

        private readonly Dictionary<string, IController> _controllers;
        private readonly List<IInitializable> _initializables;
        private readonly List<ILogicUpdatable> _logicUpdatables;
        private readonly List<IPhysicUpdatable> _physicUpdatables;
        private readonly List<ILateUpdatable> _lateUpdatables;
        private readonly List<IDestroyable> _destroyables;

        #endregion


        #region ClassicLifeCycle

        internal ControllersRepository()
        {
            _controllers = new Dictionary<string, IController>();
            _initializables = new List<IInitializable>();
            _logicUpdatables = new List<ILogicUpdatable>();
            _physicUpdatables = new List<IPhysicUpdatable>();
            _lateUpdatables = new List<ILateUpdatable>();
            _destroyables = new List<IDestroyable>();
        }

        #endregion


        #region Methods

        internal ControllersRepository Add(IController controller)
        {
            if (controller is IInitializable initializable)
                _initializables.Add(initializable);
            if (controller is ILogicUpdatable logicUpdatable)
                _logicUpdatables.Add(logicUpdatable);
            if (controller is IPhysicUpdatable physicsUpdatable)
                _physicUpdatables.Add(physicsUpdatable);
            if (controller is ILateUpdatable lateUpdatable)
                _lateUpdatables.Add(lateUpdatable);
            if (controller is IDestroyable destroyable)
                _destroyables.Add(destroyable);

            return this;
        }

        internal void Register<T>(T controller) where T : IController
        {
            var key = typeof(T).Name;
            if (_controllers.ContainsKey(key))
                throw new InvalidOperationException($"Attempted to register controller of type: {key}" +
                    $" which already register with the {GetType().Name}.");
            else
                _controllers.Add(key, controller);
        }

        internal void Unregister<T>() where T : IController
        {
            var key = typeof(T).Name;
            if (!_controllers.ContainsKey(key))
                throw new InvalidOperationException($"Attempted to unregister controller of type: {key} " +
                    $"which is not already register with the {GetType().Name}.");
            else
                _controllers.Remove(key);
        }

        internal T Get<T>() where T : IController
        {
            var key = typeof(T).Name;
            if (!_controllers.ContainsKey(key))
                throw new InvalidOperationException($"{key} not registered with {GetType().Name}.");
            else
                return (T)_controllers[key];
        }

        #endregion


        #region Interfaces

        public void Initialize()
        {
            foreach (var initializable in _initializables)
            {
                initializable.Initialize();
            }
        }

        public void LogicUpdate(float delta)
        {
            foreach (var updatable in _logicUpdatables)
            {
                updatable.LogicUpdate(delta);
            }
        }

        public void PhysicUpdate(float delta)
        {
            foreach (var updatable in _physicUpdatables)
            {
                updatable.PhysicUpdate(delta);
            }
        }

        public void LateUpdate(float delta)
        {
            foreach (var updatable in _lateUpdatables)
            {
                updatable.LateUpdate(delta);
            }
        }

        public void Destroy()
        {
            foreach (var destroyable in _destroyables)
            {
                destroyable.Destroy();
            }
        }

        #endregion

    }
}