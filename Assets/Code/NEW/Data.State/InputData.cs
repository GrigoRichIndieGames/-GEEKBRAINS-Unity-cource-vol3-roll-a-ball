using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "data input", menuName = "Data/System/dataInput")]
    internal sealed class InputData :
        ScriptableObject
    {
        [SerializeField] internal string PrefabJoystickPath;

    }
}
