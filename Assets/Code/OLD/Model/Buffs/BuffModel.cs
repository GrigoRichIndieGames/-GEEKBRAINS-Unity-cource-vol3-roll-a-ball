namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class BuffModel
    {
        #region Fields

        private PlayerModel _playerModel;
        private float _effectModificator;
        private float _timeOfAction;

        #endregion


        #region Properties

        public PlayerModel PlayerModel { get => _playerModel; set => _playerModel = value; }
        public float EffectModificator { get => _effectModificator; }
        public float TimeOfAction { get => _timeOfAction; }

        #endregion


        #region ClassicLifeCycle

        public BuffModel(BuffData data)
        {
            _effectModificator = data.EffectModificator;
            _timeOfAction = data.TimeOfAction;
        }

        #endregion
    }
}
