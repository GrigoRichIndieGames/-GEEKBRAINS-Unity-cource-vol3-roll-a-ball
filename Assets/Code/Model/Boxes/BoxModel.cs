namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class BoxModel

    {
        #region PrivateData

        private const float BOUNCE_DISTANCE = 0.5f;

        #endregion


        #region Fields

        private BoxData _data;
        private BoxState _state;

        #endregion


        #region Properties

        public BoxData Data { get => _data; }
        public BoxState State { get => _state; set => _state = value; }

        #endregion


        #region ClassicLifeCycle

        public BoxModel(BoxData data)
        {
            _data = data;
            _state = new BoxState();
        }

        #endregion
    }
}
