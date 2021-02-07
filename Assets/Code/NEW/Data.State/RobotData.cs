using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "RobotController", menuName = "Data/Robot/dataRobot")]
    internal sealed class RobotData : ScriptableObject
    {
        [Header("Check settings")]
        [SerializeField] internal LayerMask WallLayerMask;
        [SerializeField] internal LayerMask FloorLayerMask;
        [SerializeField] internal float CheckDistance;
        [SerializeField] internal float CheckPositionRange;
        [Header("Move settings")]
        [SerializeField] internal float MoveSpeed;
        [SerializeField] internal float JumpForce;
        [SerializeField] internal float GravityMod;
        [Header("player settings")]
        [SerializeField] internal float HealthPoint;
    }
}
