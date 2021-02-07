using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class PlayerControllerInitializator
    {
        internal PlayerControllerInitializator(int robotID, GameController controller, GameContextLocator locator)
        {
            var data = ResourcesLoader.GetData<PlayerData>(controller.PathData.RootDataFolder,
                        controller.PathData.DataRobot[robotID]);
            var prefab = ResourcesLoader.GetPrefab(controller.PathData.RootPrefabsFolder, controller.PathData.PrefabRobot[robotID]);
            var clone = Object.Instantiate(prefab, controller.Data.StartPositionPlayer);
            var newController = new PlayerController(data, clone, locator);
            var view = clone.AddComponent<PlayerView>();

            clone.name = nameof(PlayerController);
            view.Initialize(newController);

            locator.Register(newController);
            locator.Get<UpdateController>().Register(newController);

            Logger.Print(newController);
        }
    }
}
