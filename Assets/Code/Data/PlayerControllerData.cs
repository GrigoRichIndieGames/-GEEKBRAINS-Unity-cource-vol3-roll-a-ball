using UnityEngine;


namespace GeekbrainsStudy
{
    [CreateAssetMenu(fileName = "PlayerController", menuName = "Data/PlayerController")]
    internal sealed class PlayerControllerData : ScriptableObject
    {
        [SerializeField] internal float HealthPoint;
        [SerializeField] internal float MoveSpeed;
    }
}
