using UnityEngine;


namespace GeekbrainsStudy
{
    [System.Serializable]
    internal sealed class PathData
    {
        [Header("Prefabs")]
        [SerializeField] internal string RootPrefabsFolder;
        [SerializeField] internal string PrefabPlayer;
        [Header("Data")]
        [SerializeField] internal string RootDataFolder;
        [SerializeField] internal string DataPlayerControllera;
    }
}
