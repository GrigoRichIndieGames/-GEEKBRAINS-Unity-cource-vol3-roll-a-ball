using System.Collections.Generic;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class PlayerModel
    {
        #region Fields

        private PlayerData _data;
        private PlayerState _state;


        #endregion


        #region Properties

        internal PlayerData Data { get => _data; set => _data = value; }
        internal PlayerState State { get => _state; set => _state = value; }

        #endregion


        #region ClassicLifeCycle

        internal PlayerModel(PlayerData data)
        {
            _data = data;
            _state = new PlayerState(data);
        }



        #endregion
    }
}
