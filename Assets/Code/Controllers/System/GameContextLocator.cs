using System;
using System.Collections.Generic;
using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class GameContextLocator
    {
        #region Fields

        private readonly Dictionary<string, IController> _controllers;

        #endregion


        #region ClassicLifeCycle

        internal GameContextLocator()
        {
            _controllers = new Dictionary<string, IController>();
        }

        #endregion


        #region Methods

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
    }
}
