using UnityEngine;


namespace GeekbrainsStudy
{
    internal sealed class AddLifeBuffController :
        BasePermanentBuffController
    {
        #region ClassicLifeCycle

        internal AddLifeBuffController(BuffData data, GameContextLocator locator) : base(data, locator) { }


        #endregion


        #region BaseTemporaryBuffController

        public override void SetBuff(PlayerModel model)
        {
            base.SetBuff(model);

            _model.PlayerModel.State.MoveSpeed += _model.EffectModificator;
        }

        #endregion
    }
}
