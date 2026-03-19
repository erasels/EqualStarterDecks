using HarmonyLib;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.Characters;

namespace EqualStarterDecks;

public class DeckPatches
{
    
    
    // Remove 1 Strike and add Flex
    [HarmonyPatch(typeof(Ironclad), nameof(Ironclad.StartingDeck), MethodType.Getter)]
    public static class ICChanges
    {
        [HarmonyPostfix]
        static void ChangeDeck(ref IEnumerable<CardModel> __result)
        {
            var deck = __result.ToList();

            // Remove strike if it wasn't changed by something else
            var strike = deck.FirstOrDefault(c => c is StrikeIronclad);
            if (strike != null)
                deck.Remove(strike);

            
            deck.Add(ModelDb.Card<eqsFlex>());

            __result = deck;
        }
    }
    
    // Remove 1 Strike and Defend
    [HarmonyPatch(typeof(Silent), nameof(Silent.StartingDeck), MethodType.Getter)]
    public static class SChanges
    {
        [HarmonyPostfix]
        static void ChangeDeck(ref IEnumerable<CardModel> __result)
        {
            var deck = __result.ToList();
            
            var strike = deck.FirstOrDefault(c => c is StrikeSilent);
            if (strike != null)
                deck.Remove(strike);
            
            var defend = deck.FirstOrDefault(c => c is DefendSilent);
            if (defend != null)
                deck.Remove(defend);

            __result = deck;
        }
    }
}