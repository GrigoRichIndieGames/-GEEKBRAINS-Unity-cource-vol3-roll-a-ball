using System;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class EventController :
        IController
    {
        #region Fields

        public event Action OnBoxWasSet;
        public event Action OnBoxDestroyed;

        #endregion


        #region ClassicLifeCycle

        internal EventController()
        {
            OnBoxWasSet += delegate { };
            OnBoxDestroyed += delegate { };
        }

        #endregion


        #region Methods

        internal void BoxWasSet() => OnBoxWasSet.Invoke();
        internal void BoxDestroyed() => OnBoxDestroyed.Invoke();

        #endregion
    }
}
