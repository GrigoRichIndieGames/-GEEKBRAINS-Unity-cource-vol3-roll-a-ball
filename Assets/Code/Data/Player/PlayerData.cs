using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    [CreateAssetMenu(fileName = "PlayerController", menuName = "Data/dataRobot")]
    internal sealed class PlayerData : ScriptableObject
    {
        [Header("Check settings")]
        [SerializeField] internal LayerMask WallLayerMask;
        [SerializeField] internal LayerMask FloorLayerMask;
        [SerializeField] internal float CheckRadious;
        [Header("Move settings")]
        [SerializeField] internal float MoveSpeed;
        [SerializeField] internal float JumpForce;
        [Header("player settings")]
        [SerializeField] internal float HealthPoint;
    }
}
