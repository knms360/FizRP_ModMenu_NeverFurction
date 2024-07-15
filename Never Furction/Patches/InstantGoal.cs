using HarmonyLib;
using UnityEngine;
using UnityEngine.Events;

namespace Never_Furction.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(OrbScript))]
    internal class InstantGoal
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
/*        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void instantgoalpatch(ref ActionSceneManager ___actionSceneManager, ref int ___stageIndex, ref int ___actIndex, ref string ___autoSceneName, ref bool ___autoSceneLoad, ref UnityEvent ___events_オ\u30FCブ獲得後イベント, ref bool ___actCleard, ref UnityEvent ___events_オ\u30FCブ獲得時イベント, ref Component __instance)
        {
            if (Never_FurctionPlugin.instantgoalbutton.Value == "true")
            {
                Never_FurctionPlugin.instantgoalbutton.Value = "false";
                ___actionSceneManager.SetState_OrbGet(___stageIndex, ___actIndex, ___autoSceneName, ___autoSceneLoad, ___events_オ\u30FCブ獲得後イベント);
                ___actCleard = true;
                ___events_オ\u30FCブ獲得時イベント.Invoke();
                UnityEngine.Object.Destroy(__instance.gameObject);
            }
        }
        [HarmonyPatch("Start")]
        [HarmonyPrefix]
        static void instantgoalpatchfalse(ref ActionSceneManager ___actionSceneManager, ref int ___stageIndex, ref int ___actIndex, ref string ___autoSceneName, ref bool ___autoSceneLoad, ref UnityEvent ___events_オ\u30FCブ獲得後イベント, ref bool ___actCleard, ref UnityEvent ___events_オ\u30FCブ獲得時イベント, ref Component __instance)
        {
            Never_FurctionPlugin.instantgoalbutton.Value = "false";
        }

        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>*/
    }
}