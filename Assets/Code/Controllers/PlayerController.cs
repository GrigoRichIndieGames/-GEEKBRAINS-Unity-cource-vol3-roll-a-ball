using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class PlayerController :
        IController,
        IPhysicsUpdatable
    {
        #region Fields

        private PlayerControllerModel _model;

        private GameContextLocator _locator;
        private InputSystem _input;

        #endregion


        #region Properties

        internal PlayerControllerModel Model { get => _model; set => _model = value; }

        #endregion


        #region ClassicLifeCycle

        internal PlayerController(PlayerControllerData data, GameObject playerObject, GameContextLocator locator)
        {
            _locator = locator;
            _input = locator.Get<InputSystem>();

            Model = new PlayerControllerModel(data);
            _model.State.PlayerTransform = playerObject.transform;
            _model.State.PlayerRigidbody = playerObject.GetComponent<Rigidbody>();
            _model.State.MoveSpeed = _model.Data.MoveSpeed;
            _model.State.HealthPoint = _model.Data.HealthPoint;
        }

        #endregion


        #region Methods

        public void Move()
        {
            var movement = new Vector3(_input.Model.Horizontal, 0.0f, _input.Model.Vertical);
            _model.State.PlayerRigidbody.AddForce(movement * _model.State.MoveSpeed);
        }

        public void Heal()
        {
            _model.State.HealthPoint = _model.Data.HealthPoint;
        }

        #endregion


        #region IFixedUpdatable

        public void PhysicsUpdate()
        {
            Move();
        }

        #endregion
    }
}
