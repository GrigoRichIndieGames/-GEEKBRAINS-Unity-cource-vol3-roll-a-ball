namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class BoxModel

    {
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
