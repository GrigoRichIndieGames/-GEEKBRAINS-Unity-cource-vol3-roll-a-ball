using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "BoxController", menuName = "Data/dataBox")]
    internal sealed class BoxData : ScriptableObject
    {
        public float BoxModificator;
        public float MaxMoveDistance;
    }
}
