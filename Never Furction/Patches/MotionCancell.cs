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
/*    [HarmonyPatch(typeof(ActionSceneManager))]
    internal class MotionCancell
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void motioncancell(ref List<PlayerBase> ___players, ref int ___charactorIndex, ref ActionSceneManager.SceneState ___sceneState)
        {
            ___players[___charactorIndex].Pause(false);
            ___sceneState = ActionSceneManager.SceneState.Scene_Playable;
        }
    }*/
}