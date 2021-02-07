using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class RobotState
    {
        internal Transform RobotTransform;

        internal float HorizontalAxisInput;

        internal float HealthPoint;
        internal float MoveSpeed;
        internal float JumpForce;
        internal float GravityMod;
        internal bool IsGrounded;

        internal RobotState(RobotData data)
        {
            HealthPoint = data.HealthPoint;
            MoveSpeed = data.MoveSpeed;
            JumpForce = data.JumpForce;
            GravityMod = data.GravityMod;
        }
    }
}
