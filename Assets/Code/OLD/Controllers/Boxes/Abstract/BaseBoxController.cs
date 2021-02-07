using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal abstract class BaseBoxController :
        IController,
        IDestroyable,
        ILogicUpdatable,
        IPhysicsUpdatable
    {
        #region PrivateData

        private const float BOUNCE_DISTANCE = 0.5f;

        #endregion


        #region Fields

        protected BoxModel _model;
        protected GameContextLocator _locator;

        #endregion


        #region ClassicLifeCycle

        internal BaseBoxController(BoxData data, GameContextLocator locator)
        {
            _model = new BoxModel(data);
            _locator = locator;
        }

        #endregion


        #region Methods

        internal void ColliderInteracr(Collider collision)
        {

        }

        internal void SetLevelID(int id)
        {

        }
        internal void Enable()
        {
            _model.State.IsEnabled = true;
        }

        private void Falling()
        {
            if (_model.State.IsGrounded)
            {
                _model.State.IsLanded = true;
                _model.State.BoxTransform.position = new Vector3
                        (
                            _model.State.BoxTransform.position.x,
                            0.0f,
                            0.0f
                        );
            }
            else
            {
                _model.State.BoxTransform.position -= Vector3.down * _model.Data.GravityValue * Time.deltaTime;
            }
        }

        private void CheckGround()
        {
            if (_model.State.IsEnabled && !_model.State.IsLanded)
            {
                var checkLanding = Physics.OverlapSphere
                (
                    _model.State.BoxTransform.position,
                    _model.Data.CheckRadious,
                    _model.Data.FloorLayerMask
                );
                _model.State.IsGrounded = checkLanding.Length > 0 ? true : false;
            }
        }
        private void CheckIfCanFall()
        {
            if (_model.State.IsGrounded && _model.State.StackLevel > 0)
            {
                var checkFloor = Physics.OverlapSphere
                (
                    _model.State.BoxTransform.position,
                    _model.Data.CheckRadious,
                    _model.Data.FloorLayerMask
                );
                _model.State.IsGrounded = checkFloor.Length > 0 ? true : false;
            }
        }

        #endregion


        #region Interfaces

        public virtual void DestroyController(GameObject view)
        {
            Object.Destroy(view);
        }

        public void LogicUpdate()
        {
            Falling();
        }

        public void PhysicsUpdate()
        {
            CheckGround();
        }

        #endregion
    }
}
