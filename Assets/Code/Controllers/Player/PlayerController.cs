using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class PlayerController :
        IController,
        IPhysicsUpdatable,
        ILogicUpdatable,
        IDestroyable
    {
        #region Fields

        private PlayerModel _model;

        private GameContextLocator _locator;
        private InputSystem _input;

        #endregion


        #region Properties

        internal PlayerModel Model { get => _model; set => _model = value; }

        #endregion


        #region ClassicLifeCycle

        internal PlayerController(PlayerData data, GameObject playerObject, GameContextLocator locator)
        {
            _locator = locator;
            _input = locator.Get<InputSystem>();

            Model = new PlayerModel(data);
            _model.State.PlayerTransform = playerObject.transform;
            _model.State.PlayerRigidbody = playerObject.GetComponent<Rigidbody>();
            _model.State.PlayerRigidbody = playerObject.GetComponent<Rigidbody>();
        }

        #endregion


        #region Methods

        internal void Interact(Collider collider)
        {
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
        }

        private void UpdateState()
        {
            var checkFloor = Physics.OverlapSphere
                (
                    _model.State.PlayerTransform.position,
                    _model.Data.CheckRadious,
                    _model.Data.FloorLayerMask
                );
            if (checkFloor.Length > 0)
                _model.State.IsGrounded = true;
            else
                _model.State.IsGrounded = false;
        }

        private void Move()
        {
            var velocity = new Vector3
                (
                    _input.Model.Horizontal * _model.State.MoveSpeed,
                    _model.State.PlayerRigidbody.velocity.y,
                    0.0f
                );

            _model.State.PlayerRigidbody.velocity = velocity;
        }

        private void Jump()
        {
            if (_input.Model.IsJump && _model.State.IsGrounded)
                _model.State.PlayerRigidbody.AddForce(Vector3.up * _model.State.JumpForce, ForceMode.Impulse);
        }

        #endregion


        #region Interfaces

        public void PhysicsUpdate()
        {
            UpdateState();
            Move();
        }

        public void LogicUpdate()
        {
            Jump();
        }

        public void DestroyController(GameObject view)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
