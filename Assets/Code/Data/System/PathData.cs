using UnityEngine;


namespace GeekbrainsStudy
{
    [System.Serializable]
    internal sealed class PathData
    {
        [Header("Prefabs")]
        [SerializeField] internal string RootPrefabsFolder;
        [SerializeField] internal string[] PrefabRobot;
        [Header("Data")]
        [SerializeField] internal string RootDataFolder;
        [SerializeField] internal string[] DataRobot;
    }
}
