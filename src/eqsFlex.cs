using BaseLib.Abstracts;
using BaseLib.Utils;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.HoverTips;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models.CardPools;
using MegaCrit.Sts2.Core.Models.Powers;

namespace EqualStarterDecks;

[Pool(typeof(IroncladCardPool))]
public class eqsFlex() : CustomCardModel(0, CardType.Skill, CardRarity.Basic, TargetType.Self) {
    public override IEnumerable<IHoverTip> ExtraHoverTips => [HoverTipFactory.FromPower<StrengthPower>()];
    
    public override IEnumerable<DynamicVar> CanonicalVars => [new PowerVar<StrengthPower>(2M)];

    public override async Task OnPlay(PlayerChoiceContext choiceContext, CardPlay play)
    {
        var flexPower = await PowerCmd.Apply<eqsFlexPower>(Owner.Creature, DynamicVars.Strength.BaseValue, Owner.Creature, this);
    }

    public override void OnUpgrade()
    {
        DynamicVars.Strength.UpgradeValueBy(2M);
    }
}