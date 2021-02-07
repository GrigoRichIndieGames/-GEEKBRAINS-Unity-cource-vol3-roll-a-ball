namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class EventControllerInitializator
    {
        internal EventControllerInitializator(GameContextLocator locator)
        {
            var newController = new EventController();
            locator.Register(newController);

            Logger.Print(newController);
        }
    }
}
