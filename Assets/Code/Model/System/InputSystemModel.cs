namespace GeekbrainsStudy
{
    internal sealed class InputSystemModel
    {
        #region Fields

        private float _horizontal;
        private float _vertical;
        private bool _isInteract;
        private bool _isJump;

        #endregion


        #region Properties

        public float Horizontal { get => _horizontal; set => _horizontal = value; }
        public float Vertical { get => _vertical; set => _vertical = value; }
        public bool IsInteract { get => _isInteract; set => _isInteract = value; }
        public bool IsJump { get => _isJump; set => _isJump = value; }

        #endregion
    }
}
