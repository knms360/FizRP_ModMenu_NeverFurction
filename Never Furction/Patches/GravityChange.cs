using HarmonyLib;
using static Never_Furction.Never_FurctionPlugin;

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
    internal class GravityChange
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("Update_")]
        [HarmonyPrefix]
        static void gravitypatch(ref float ___gravityScale_default, ref float ___gravityScale_underWater)
        {
            if (Never_FurctionPlugin.Gravitylist.Value == Never_FurctionPlugin.ItemList.MOON)
            {
                ___gravityScale_default = 0.25f;
                ___gravityScale_underWater = 0.05f;
            }
            else if (Never_FurctionPlugin.Gravitylist.Value == Never_FurctionPlugin.ItemList.ZERO)
            {
                ___gravityScale_default = 0f;
                ___gravityScale_underWater = 0f;
            }
            else if (Never_FurctionPlugin.Gravitylist.Value == Never_FurctionPlugin.ItemList.SUN)
            {
                ___gravityScale_default = 4f;
                ___gravityScale_underWater = 0.8f;
            }
            else if (Never_FurctionPlugin.Gravitylist.Value == Never_FurctionPlugin.ItemList.EARTH)
            {
                ___gravityScale_default = 1f;
                ___gravityScale_underWater = 0.2f;
            }
            else if (Never_FurctionPlugin.Gravitylist.Value == Never_FurctionPlugin.ItemList.REVERCE)
            {
                ___gravityScale_default = -1f;
                ___gravityScale_underWater = -0.2f;
            }
        }
    }
}