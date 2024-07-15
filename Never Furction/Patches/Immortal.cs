using HarmonyLib;
using UnityEngine;

namespace Never_Furction.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(PlayerBase))]
    internal class Immortal
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("CheckFallDeath")]
        [HarmonyPrefix]
        static void immortal(ref Component __instance, ref ActionSceneManager ___actionSceneManager)
        {
            if (Never_FurctionPlugin.immortalchk.Value)
            {
                Never_FurctionPlugin.Floatsave = ___actionSceneManager.lowerLimit;
                ___actionSceneManager.lowerLimit = __instance.transform.position.y;
            }
        }
        [HarmonyPatch("CheckFallDeath")]
        [HarmonyPostfix]
        static void immortal2(ref ActionSceneManager ___actionSceneManager)
        {
            if (Never_FurctionPlugin.immortalchk.Value)
            {
                ___actionSceneManager.lowerLimit = Never_FurctionPlugin.Floatsave;
            }
        }
    }
}