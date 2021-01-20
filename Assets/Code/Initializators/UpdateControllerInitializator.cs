namespace GeekbrainsStudy
{
    internal sealed class UpdateControllerInitializator
    {
        internal UpdateControllerInitializator(GameController controller, GameContextLocator locator)
        {
            var newController = new UpdateController();
            var view = controller.gameObject.AddComponent<UpdateControllerView>();
            locator.Register(newController);
            view.Initialize(newController);
        }
    }
}
