using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class InputSystemInitializator
    {
        internal InputSystemInitializator(ControllersRepository controllersRepository, Data data)
        {
            var controllerData = Resources.Load<InputData>(data.InputDataPath);
            var view = Object.Instantiate(Resources.Load<VirtualJoystickView>(controllerData.PrefabJoystickPath), data.InputLayer);
            var controller = new InputController(controllersRepository, view);

            controllersRepository.Add(controller);
        }
    }
}

