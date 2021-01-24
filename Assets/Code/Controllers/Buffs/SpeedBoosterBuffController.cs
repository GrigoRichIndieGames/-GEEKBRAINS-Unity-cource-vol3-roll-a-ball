using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class SpeedBoosterBuffController :
        BaseTemporaryBuffController
    {
        #region ClassicLifeCycle

        internal SpeedBoosterBuffController(BuffData data, GameContextLocator locator) : base(data, locator) { }


        #endregion


        #region BaseTemporaryBuffController

        public override void SetBuff(PlayerModel model)
        {
            base.SetBuff(model);

            _model.PlayerModel.State.MoveSpeed *= _model.EffectModificator;
        }

        internal override void DeactivateBuff()
        {
            _model.PlayerModel.State.MoveSpeed = _model.PlayerModel.Data.MoveSpeed;
        }

        #endregion
    }
}
