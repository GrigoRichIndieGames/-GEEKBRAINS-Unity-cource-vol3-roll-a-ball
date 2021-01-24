namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class GameContextLocatorInitializator
    {
        internal GameContextLocatorInitializator(Initializator initializator)
        {
            var newController = new GameContextLocator();
            initializator.SetLocator(newController);

            Logger.Print(newController);
        }
    }
}
