using BaseLib.Abstracts;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Powers;

namespace EqualStarterDecks;

public class eqsFlexPower : TemporaryStrengthPower
{
    public override AbstractModel OriginModel => ModelDb.Card<eqsFlex>();
}