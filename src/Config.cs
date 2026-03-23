using BaseLib.Config;

namespace EqualStarterDecks;

public class Config: SimpleModConfig
{
    [ConfigSection("decksizes")]
    public static bool SilentFour { get; set; } = true;
    public static bool IroncladFour { get; set; } = true;

    [ConfigSection("deckadds")]
    public static bool IroncladFlex { get; set; } = true;
}