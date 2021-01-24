using UnityEngine;


namespace GeekbrainsStudy
{
    [System.Serializable]
    internal sealed class GameControllerData
    {
        [Header("Player settings")]
        [SerializeField] internal Transform StartPositionPlayer;
    }
}
