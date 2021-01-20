namespace GeekbrainsStudy
{
    internal interface ILateUpdatable :
        IUpdatable
    {
        void LateUpdate();
    }
}