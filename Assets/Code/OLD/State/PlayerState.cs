using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class PlayerState
    {
        internal Transform PlayerTransform;
        internal Rigidbody PlayerRigidbody;

        internal float HealthPoint;
        internal float MoveSpeed;
        internal float JumpForce;
        internal bool IsGrounded;

        internal PlayerState(PlayerData data)
        {
            HealthPoint = data.HealthPoint;
            MoveSpeed = data.MoveSpeed;
            JumpForce = data.JumpForce;
        }
    }
}
