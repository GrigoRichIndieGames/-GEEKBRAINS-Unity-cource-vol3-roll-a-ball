using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    [CreateAssetMenu(fileName = "BoxController", menuName = "Data/dataBox")]
    internal sealed class BoxData : ScriptableObject
    {
        public LayerMask FloorLayerMask;
        public LayerMask WallLayerMask;
        public LayerMask BoxLayerMask;
        public LayerMask PlayerLayerMask;
        public float BoxModificator;
        public float MaxMoveDistance;
        public float CheckRadious;
        public float GravityValue;
    }
}
