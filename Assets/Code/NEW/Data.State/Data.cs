using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/System/GameData")]
    internal sealed class Data :
        ScriptableObject
    {
        [Header("Data")]
        [SerializeField] internal string TagStartPosition;
        [Header("Data")]
        [SerializeField] internal string InputDataPath;
        [SerializeField] internal string[] RobotsDataPath;
        [Header("Prefabs")]
        [SerializeField] internal string PrefabCanvasPath;
        [SerializeField] internal string PrefabInputLayerPath;
        [SerializeField] internal string[] PrefabsRobotPath;

        internal Transform SystemRoot;
        internal Transform MainCanvas;
        internal Transform InputLayer;
    }
}
