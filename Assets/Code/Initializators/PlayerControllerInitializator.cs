using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class PlayerControllerInitializator
    {
        internal PlayerControllerInitializator(GameController controller, GameContextLocator locator)
        {
            var data = ResourcesLoader.GetData<PlayerControllerData>(controller.PathData.RootDataFolder, controller.PathData.DataPlayerControllera);
            var prefab = ResourcesLoader.GetPrefab(controller.PathData.RootPrefabsFolder, controller.PathData.PrefabPlayer);
            var clone = Object.Instantiate(prefab, controller.Data.StartPositionPlayer);
            var newController = new PlayerController(data, clone, locator);
            var view = clone.AddComponent<PlayerControllerView>();

            clone.name = nameof(PlayerController);
            view.Initialize(newController);

            locator.Register(newController);
            locator.Get<UpdateController>().Register(newController);
        }
    }
}
