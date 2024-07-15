using HarmonyLib;
using System;
using System.Reflection;
using UnityEngine.PlayerLoop;

namespace Never_Furction.Patches
{
    // TODO Review this file and update to your own requirements, or remove it altogether if not required

    /// <summary>
    /// Sample Harmony Patch class. Suggestion is to use one file per patched class
    /// though you can include multiple patch classes in one file.
    /// Below is included as an example, and should be replaced by classes and methods
    /// for your mod.
    /// </summary>
    [HarmonyPatch(typeof(Door))]
    internal class AnywhereDoor
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void anywheredoor(ref Door __instance, ref ActionSceneManager ___actionSceneManager, ref bool ___entered)
        {
            if (Never_FurctionPlugin.anywheredoorbutton.Value == "1")
            {
                ___entered = true;
                MethodInfo method = typeof(Door).GetMethod("DoorEnter", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                // インスタンスを作成する
                object instance = Activator.CreateInstance(typeof(Door));
                // 探したメソッドを実行する。　呼ぶメソッドはint,intを引数にし、戻り値もintのため、intにcastしている
                method.Invoke(__instance, null);
                Never_FurctionPlugin.anywheredoorbutton.Value = "0";
            }
            else if (Never_FurctionPlugin.anywheredoorbutton.Value == "2")
            {
                ___actionSceneManager.DoorStageSelectWarp();
                Never_FurctionPlugin.anywheredoorbutton.Value = "0";
            }
        }
        [HarmonyPatch("Start")]
        [HarmonyPrefix]
        static void anywheredoorfalse()
        {
            Never_FurctionPlugin.anywheredoorbutton.Value = "0";

        }
    }
}