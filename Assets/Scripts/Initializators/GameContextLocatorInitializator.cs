namespace GeekbrainsStudy
{
    internal sealed class GameContextLocatorInitializator
    {
        internal GameContextLocatorInitializator(Initializator initializator)
        {
            initializator.SetLocator(new GameContextLocator());
        }
    }
}
