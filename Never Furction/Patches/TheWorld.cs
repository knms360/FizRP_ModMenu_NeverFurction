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
    [HarmonyPatch(typeof(ActionSceneManager))]
    internal class TheWorld
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void theworldpatch(ref List<EnemyBase> ___enemys, ref List<StageGimmickBase> ___stageGimmicks)
        {
            if (!Never_FurctionPlugin.theworldchk.Value)
            {
                for (int j = 0; j < ___enemys.Count; j++)
                {
                    ___enemys[j].Pause(false);
                }
                for (int k = 0; k < ___stageGimmicks.Count; k++)
                {
                    ___stageGimmicks[k].Pause(false);
                }
            }
            else
            {
                for (int j = 0; j < ___enemys.Count; j++)
                {
                    ___enemys[j].Pause(true);
                }
                for (int k = 0; k < ___stageGimmicks.Count; k++)
                {
                    ___stageGimmicks[k].Pause(true);
                }
            }
        }
    }
}