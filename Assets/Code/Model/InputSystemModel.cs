namespace GeekbrainsStudy
{
    internal sealed class InputSystemModel
    {
        #region Fields

        private float _horizontal;
        private float _vertical;
        private bool _isInteract;

        #endregion


        #region Properties

        public float Horizontal { get => _horizontal; set => _horizontal = value; }
        public float Vertical { get => _vertical; set => _vertical = value; }
        public bool IsInteract { get => _isInteract; set => _isInteract = value; }

        #endregion
    }
}
