using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class CameraControllerInitializator
    {
        internal CameraControllerInitializator(GameController controller, GameContextLocator locator)
        {
            var gameObject = Camera.main.gameObject;
            var newController = new CameraController(gameObject, locator);

            locator.Register(newController);
            locator.Get<UpdateController>().Register(newController);
        }
    }
}
