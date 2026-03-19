using BaseLib.Config;
using MegaCrit.Sts2.Core.Entities.Cards;

namespace EqualStarterDecks;

public class Config: SimpleModConfig
{
    [ConfigSection("Deck sizes")]
    public static bool SilentFour { get; set; } = true;
    public static bool IroncladFour { get; set; } = true;

    [ConfigSection("Deck Changes")]
    public static bool IroncladFlex { get; set; } = true;
}