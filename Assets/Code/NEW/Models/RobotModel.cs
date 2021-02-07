namespace GrigorichIndieGames_CosmoLoader

{
    internal sealed class RobotModel
    {
        #region Fields

        private RobotData _data;
        private RobotState _state;


        #endregion


        #region Properties

        internal RobotData Data { get => _data; set => _data = value; }
        internal RobotState State { get => _state; set => _state = value; }

        #endregion


        #region ClassicLifeCycle

        internal RobotModel(RobotData data)
        {
            _data = data;
            _state = new RobotState(data);
        }

        #endregion
    }
}
