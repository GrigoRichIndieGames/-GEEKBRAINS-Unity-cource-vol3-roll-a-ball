using System;

namespace GrigorichIndieGames_CosmoLoader
{
    internal sealed class MobileInputHorizontal :
        IUserInputAxis
    {
        public event Action<float> OnValueChanged = contex => { };

        private VirtualJoystickView _view;

        public MobileInputHorizontal(VirtualJoystickView view)
        {
            _view = view;
        }

        public void GetInput()
        {
            OnValueChanged.Invoke(_view.HorizontalAxis);
        }
    }
}