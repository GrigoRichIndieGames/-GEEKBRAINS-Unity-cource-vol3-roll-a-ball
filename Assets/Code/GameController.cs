using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class GameController :
        MonoBehaviour
    {
        #region Fields

        [SerializeField] private GameControllerData _data;
        [SerializeField] private PathData _pathData;

        #endregion


        #region Properties

        internal GameControllerData Data => _data;
        internal PathData PathData => _pathData;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            new Initializator(this);
        }

        #endregion
    }
}
