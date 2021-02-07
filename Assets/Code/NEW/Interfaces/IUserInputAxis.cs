using System;


namespace GrigorichIndieGames_CosmoLoader
{
    internal interface IUserInputAxis
    {
        event Action<float> OnValueChanged;
        void GetInput();
    }
}
