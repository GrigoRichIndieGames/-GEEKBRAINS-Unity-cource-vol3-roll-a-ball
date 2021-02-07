using static UnityEngine.Debug;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal static class Logger
    {
        internal static void Print<T>(T t) where T : IController
        {
            var message = $"Controller: {t} was initialized";
            Log(message);
        }
    }
}
