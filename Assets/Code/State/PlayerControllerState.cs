using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class PlayerControllerState
    {
        internal Transform PlayerTransform;
        internal Rigidbody PlayerRigidbody;

        internal float HealthPoint;
        internal float MoveSpeed;
        internal float JumpForce;
        internal bool IsGrounded;

        internal PlayerControllerState(PlayerData data)
        {
            HealthPoint = data.HealthPoint;
            MoveSpeed = data.MoveSpeed;
            JumpForce = data.JumpForce;
        }
    }
}
