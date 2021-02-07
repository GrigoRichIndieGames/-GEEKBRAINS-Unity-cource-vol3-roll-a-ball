namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class InputController :
        IController,
        ILogicUpdatable,
        IDestroyable
    {
        #region Fields

        private readonly IUserInputAxis _horizontal;
        private ControllersRepository _controllersRepository;

        #endregion


        #region Properties

        internal IUserInputAxis HorizontalAxis => _horizontal;

        #endregion


        #region ClassicLifeCycle

        internal InputController(ControllersRepository controllersRepository, VirtualJoystickView virtualJoystickView)
        {
            _controllersRepository = controllersRepository;
            _controllersRepository.Register(this);
            _horizontal = new MobileInputHorizontal(virtualJoystickView);
        }

        #endregion        


        #region Interfaces

        public void LogicUpdate(float delta)
        {
            _horizontal.GetInput();
        }

        public void Destroy()
        {
            _controllersRepository.Unregister<InputController>();
        }

        #endregion

    }
}