using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class GameController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private PathData _data;

        #endregion


        #region Properties

        internal PathData Data => _data;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            new Initializator(this);
        }

        #endregion
    }
}
