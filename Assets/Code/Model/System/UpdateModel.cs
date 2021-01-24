﻿using System.Collections.Generic;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class UpdateModel
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

        internal UpdateModel()
        {
            _iUpdatables = new List<ILogicUpdatable>();
            _iFixedUpdatables = new List<IPhysicsUpdatable>();
            _iLateUpdatables = new List<ILateUpdatable>();
        }

        #endregion
    }
}
