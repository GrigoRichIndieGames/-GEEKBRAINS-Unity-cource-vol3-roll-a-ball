namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class InputSystemInitializator
    {
        internal InputSystemInitializator(GameContextLocator locator)
        {
            var newController = new InputSystem();
            locator.Register(newController);
            locator.Get<UpdateController>().Register(newController);

            Logger.Print(newController);
        }
    }
}
