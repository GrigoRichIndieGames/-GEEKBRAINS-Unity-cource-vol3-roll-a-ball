using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class BoxState
    {
        internal Transform PlayerTransform;
        internal Vector3 PreviousPosition;
        internal float CurrentDistance;
        internal bool IsGround;
    }
}
