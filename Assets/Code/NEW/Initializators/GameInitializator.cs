namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class GameInitializator
    {
        internal GameInitializator(ControllersRepository controllersRepository, Data data)
        {
            new CanvasBuilder(data);
            new InputSystemInitializator(controllersRepository, data);
            new RobotControllerInitializator(0, controllersRepository, data);//TODO: save system
        }
    }
}
