using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class InputSystem :
        IController,
        ILogicUpdatable
    {
        #region PrivateData

        private const string HORIZONTAL_AXIS_NAME = "Horizontal";
        private const string VERTICAL_AXIS_NAME = "Vertical";
        private const string INTERACT_BUTTON_NAME = "Vertical";

        #endregion


        #region Fields

        private InputSystemModel _model;

        #endregion


        #region Properties

        internal InputSystemModel Model { get => _model;}

        #endregion


        #region ClassicLifeCycle

        internal InputSystem()
        {
            _model = new InputSystemModel();
        }

        #endregion


        #region IUpdatable

        public void LogicUpdate()
        {
            Model.Horizontal = Input.GetAxis(HORIZONTAL_AXIS_NAME);
            Model.Vertical = Input.GetAxis(VERTICAL_AXIS_NAME);
            Model.IsInteract = Input.GetButtonDown(INTERACT_BUTTON_NAME) ? true : false;
        }

        #endregion
    }
}
