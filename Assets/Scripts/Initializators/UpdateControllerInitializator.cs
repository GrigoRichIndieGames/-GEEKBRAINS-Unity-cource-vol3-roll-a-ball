namespace GeekbrainsStudy
{
    internal sealed class UpdateControllerInitializator
    {
        internal UpdateControllerInitializator(GameController controller, GameContextLocator locator)
        {
            var updater = new UpdateController();
            var view = controller.gameObject.AddComponent<UpdateView>();
            locator.Register(updater);
            view.Initialize(updater);
        }
    }
}
