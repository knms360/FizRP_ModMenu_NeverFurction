using HarmonyLib;
using System.Collections.Generic;

namespace Never_Furction.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(MyControlExpantion))]
    internal class TurboButton
    {
        [HarmonyPatch("GetDashButtonDown")]
        [HarmonyPostfix]
        static void dashcallturbo(ref bool __result)
        {
            if (Never_FurctionPlugin.turboattackchk.Value)
            {
                __result = true;
            }
        }
        [HarmonyPatch("GetDashButtonUp")]
        [HarmonyPostfix]
        static void dashcallturbo2(ref bool __result)
        {
            if (Never_FurctionPlugin.turboattackchk.Value)
            {
                __result = true;
            }
        }
    }
}