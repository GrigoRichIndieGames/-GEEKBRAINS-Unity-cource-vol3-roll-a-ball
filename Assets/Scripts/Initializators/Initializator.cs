﻿namespace GeekbrainsStudy
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
        }

        #endregion


        #region Methods

        internal void SetLocator(GameContextLocator locator) => _locator = locator;

        #endregion
    }
}
