using System;
using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class RobotView :
        MonoBehaviour
    {
        #region Fields

        public Action<int> OnTriggerStateChanged;

        #endregion


        #region Methods

        public void Initialize()
        {
            OnTriggerStateChanged = context => { };
        }

        #endregion


        #region UnityMethods

        private void OnTriggerEnter(Collider other) => OnTriggerStateChanged.Invoke(other.gameObject.GetInstanceID());

        #endregion
    }
}
