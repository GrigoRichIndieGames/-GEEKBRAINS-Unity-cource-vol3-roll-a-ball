namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class Initializator
    {
        #region Fields

        private GameContextLocator _locator;

        #endregion


        #region ClassicLifeCycle

        internal Initializator(GameController controller)
        {
            new GameContextLocatorInitializator(this);
            new UpdateControllerInitializator(controller, _locator);
            new InputSystemInitializator(_locator);
            new EventControllerInitializator(_locator);
            //TODO: save system
            new PlayerControllerInitializator(0, controller, _locator);
            //new CameraControllerInitializator(controller, _locator);
        }

        #endregion


        #region Methods

        internal void SetLocator(GameContextLocator locator) => _locator = locator;

        #endregion
    }
}
