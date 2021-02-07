using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class CanvasBuilder
    {
        internal CanvasBuilder(Data data)
        {
            data.MainCanvas = Object.Instantiate(Resources.Load<Transform>(data.PrefabCanvasPath), data.SystemRoot);
            data.InputLayer = Object.Instantiate(Resources.Load<Transform>(data.PrefabInputLayerPath), data.MainCanvas);
        }
    }
}
