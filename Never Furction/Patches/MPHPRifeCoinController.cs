using HarmonyLib;

namespace Never_Furction.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(ActionSceneManager))]
    internal class MPHPRifeCoinController
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void MPHPCON(ref int ___coins, ref int ___specialPoint, ref int ___vitality, ref int ___rests)
        {
            if (Never_FurctionPlugin.MPHPRifeCoinControllchk.Value)
            {
                ___coins = Never_FurctionPlugin.coin.Value;
                ___rests = Never_FurctionPlugin.life.Value;
                ___specialPoint = Never_FurctionPlugin.mp.Value;
                ___vitality = Never_FurctionPlugin.hp.Value;
            }
        }

    }
}