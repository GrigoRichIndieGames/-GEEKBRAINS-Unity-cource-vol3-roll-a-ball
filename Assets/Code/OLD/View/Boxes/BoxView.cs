using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    class BoxView :
        MonoBehaviour,
        IBox
    {
        #region Fields

        private BaseBoxController _controller;

        #endregion


        #region Methods

        public void Initial(BaseBoxController controller) => _controller = controller;

        #endregion


        #region UnityMethods

        private void OnCollisionEnter(Collision collision)
        {

        }

        #endregion
    }
}
