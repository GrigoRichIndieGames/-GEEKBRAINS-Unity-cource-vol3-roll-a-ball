using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class BoxState
    {
        internal Transform BoxTransform;
        internal Vector3 PreviousPosition;
        internal float CurrentDistance;
        internal int StackLevel;
        internal bool IsEnabled;
        internal bool IsGrounded;
        internal bool IsLanded;
        internal bool CanMove;
    }
}
