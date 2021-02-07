using UnityEngine;


namespace GrigorichIndieGames_CosmoLoader_OLD
{
    internal sealed class JumpPowerBaffController :
        BaseTemporaryBuffController
    {
        #region ClassicLifeCycle

        internal JumpPowerBaffController(BuffData data, GameContextLocator locator) : base(data, locator) { }


        #endregion


        #region BaseTemporaryBuffController

        public override void SetBuff(PlayerModel model)
        {
            base.SetBuff(model);

            _model.PlayerModel.State.JumpForce *= _model.EffectModificator;
        }

        internal override void DeactivateBuff()
        {
            _model.PlayerModel.State.JumpForce = _model.PlayerModel.Data.JumpForce;
        }

        #endregion
    }
}
