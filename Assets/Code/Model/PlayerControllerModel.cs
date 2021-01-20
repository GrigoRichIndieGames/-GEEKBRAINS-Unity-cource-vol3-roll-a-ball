using System.Collections.Generic;


namespace GeekbrainsStudy
{
    internal sealed class PlayerControllerModel
    {
        #region Fields

        private PlayerControllerData _data;
        private PlayerControllerState _state;


        #endregion


        #region Properties

        internal PlayerControllerData Data { get => _data; set => _data = value; }
        internal PlayerControllerState State { get => _state; set => _state = value; }

        #endregion


        #region ClassicLifeCycle

        internal PlayerControllerModel(PlayerControllerData data)
        {
            _data = data;
            _state = new PlayerControllerState();
        }



        #endregion
    }
}
