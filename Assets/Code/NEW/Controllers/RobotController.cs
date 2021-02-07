using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class RobotController :
        IController,
        ILogicUpdatable,
        IPhysicUpdatable,
        IDestroyable
    {
        #region Fields

        private RobotView _view;
        private RobotModel _model;
        private ControllersRepository _controllersRepository;
        private InputController _input;

        #endregion


        #region Properties

        internal RobotModel Model { get => _model; set => _model = value; }

        #endregion


        #region ClassicLifeCycle

        internal RobotController(RobotData data, RobotView view, ControllersRepository controllersRepository)
        {
            _controllersRepository = controllersRepository;
            _input = _controllersRepository.Get<InputController>();
            _view = view;

            _view.OnTriggerStateChanged += Interact;
            _input.HorizontalAxis.OnValueChanged += HorizontalAxisInput;

            _model = new RobotModel(data);
            _model.State.RobotTransform = _view.transform;
        }

        #endregion


        #region Methods

        internal void Interact(int instanceID)
        {
            /*
            collider.TryGetComponent<IInteractable>(out var interactable);
            if (interactable != null)
                switch (interactable)
                {
                    case IBuff buff:
                        buff.Interact(_model);
                        break;
                    default:
                        break;
                }
            */
        }

        private void HorizontalAxisInput(float value)
        {
            _model.State.HorizontalAxisInput = value;
        }

        private void UpdateState()
        {
            RaycastHit hit;
            var rayBottom = Physics.Raycast
                (
                    _model.State.RobotTransform.position,
                    Vector3.down,
                    out hit,
                    _model.Data.CheckDistance,
                    _model.Data.FloorLayerMask
                );
            var rayLeftBottom = Physics.Raycast
                (
                    _model.State.RobotTransform.position - new Vector3(_model.Data.CheckPositionRange, 0.0f, 0.0f),
                    Vector3.down,
                    out hit,
                    _model.Data.CheckDistance,
                    _model.Data.FloorLayerMask
                );
            var rayRightBottom = Physics.Raycast
                (
                    _model.State.RobotTransform.position + new Vector3(_model.Data.CheckPositionRange, 0.0f, 0.0f),
                    Vector3.down,
                    out hit,
                    _model.Data.CheckDistance,
                    _model.Data.FloorLayerMask
                );

            if (rayLeftBottom || rayBottom || rayRightBottom)
            {
                _model.State.IsGrounded = true;
            }
            else
            {
                _model.State.IsGrounded = false;
            }

        }

        private void Move()
        {

        }

        private void Jump()
        {

        }
        private void Gravity(float delta)
        {
            if (!_model.State.IsGrounded)
                _model.State.RobotTransform.position += Vector3.down * _model.State.GravityMod * delta;
        }

        #endregion


        #region Interfaces

        public void LogicUpdate(float delta)
        {
            Gravity(delta);
            Jump();
        }

        public void PhysicUpdate(float delta)
        {
            UpdateState();
            Move();
        }

        public void Destroy()
        {
            _view.OnTriggerStateChanged = null;
            Object.Destroy(_view.gameObject);
        }

        #endregion
    }
}
