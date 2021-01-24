namespace GeekbrainsStudy
{
    internal sealed class InputSystemInitializator
    {
        internal InputSystemInitializator(GameContextLocator locator)
        {
            var newController = new InputSystem();
            locator.Register(newController);
            locator.Get<UpdateController>().Register(newController);
        }
    }
}
