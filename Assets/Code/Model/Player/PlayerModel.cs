using System.Collections.Generic;


namespace GeekbrainsStudy
{
    internal sealed class PlayerModel
    {
        #region Fields

        private PlayerData _data;
        private PlayerControllerState _state;


        #endregion


        #region Properties

        internal PlayerData Data { get => _data; set => _data = value; }
        internal PlayerControllerState State { get => _state; set => _state = value; }

        #endregion


        #region ClassicLifeCycle

        internal PlayerModel(PlayerData data)
        {
            _data = data;
            _state = new PlayerControllerState(data);
        }



        #endregion
    }
}
