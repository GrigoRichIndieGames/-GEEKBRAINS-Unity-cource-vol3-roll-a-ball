﻿using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class CameraController :
        IController,
        ILateUpdatable
    {
        #region Fields

        private CameraControllerModel _model;
        private GameContextLocator _locator;

        #endregion


        #region Properties

        internal CameraControllerModel Model { get => _model; set => _model = value; }

        #endregion


        #region ClassicLifeCycle

        internal CameraController(GameObject cameraObject, GameContextLocator locator)
        {
            _locator = locator;

            _model = new CameraControllerModel(cameraObject.transform, locator.Get<PlayerController>().Model.State.PlayerTransform);
        }

        #endregion


        #region Methods

        public void Move()
        {
            _model.CameraTransform.position = _model.PlayerTransform.position + _model.Offset;
        }

        #endregion


        #region ILateUpdatable

        public void LateUpdate()
        {
            Move();
        }

        #endregion
    }
}
