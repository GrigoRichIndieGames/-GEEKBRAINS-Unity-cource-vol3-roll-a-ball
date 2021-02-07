using System;
using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class BuffTimer :
        ILogicUpdatable
    {
        #region Fields

        private UpdateController _updateController;
        private Action _action;
        private float _timer;

        #endregion


        #region ClassicLifeCycle

        internal BuffTimer(Action action, float delay, UpdateController updateController)
        {
            _action = action;
            _timer = delay;
            _updateController = updateController;

            _updateController.Register(this);
        }

        #endregion


        #region ILogicUpdatable

        public void LogicUpdate()
        {
            if (_timer > 0)
            {
                _timer -= Time.deltaTime;
            }
            else
            {
                _action();
                _updateController.Unregister(this);
            }
        }

        #endregion
    }
}
