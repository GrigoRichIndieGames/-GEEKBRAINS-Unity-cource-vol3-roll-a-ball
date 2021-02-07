using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class CameraModel
    {
        #region Fields

        private Transform _cameraTransform;
        private Transform _playerTransform;
        private Vector3 _offset;



        #endregion


        #region Properties

        public Transform CameraTransform { get => _cameraTransform; set => _cameraTransform = value; }
        public Transform PlayerTransform { get => _playerTransform; set => _playerTransform = value; }
        public Vector3 Offset { get => _offset; set => _offset = value; }

        #endregion


        #region ClassicLifeCycle

        public CameraModel(Transform cameraTransform, Transform playerTransform)
        {
            CameraTransform = cameraTransform;
            PlayerTransform = playerTransform;
            Offset = CameraTransform.position - PlayerTransform.position;
        }

        #endregion
    }
}
