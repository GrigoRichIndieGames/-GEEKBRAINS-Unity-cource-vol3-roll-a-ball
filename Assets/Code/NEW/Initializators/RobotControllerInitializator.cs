using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class RobotControllerInitializator
    {
        internal RobotControllerInitializator(int robotID, ControllersRepository controllersRepository, Data data)
        {
            var parent = GameObject.FindGameObjectWithTag(data.TagStartPosition).transform;
            var controllerData = Resources.Load<RobotData>(data.RobotsDataPath[robotID]);
            var view = Object.Instantiate(Resources.Load<RobotView>(data.PrefabsRobotPath[robotID]), parent);
            view.Initialize();
            var controller = new RobotController(controllerData, view, controllersRepository);

            controllersRepository.Add(controller);
        }
    }
}
