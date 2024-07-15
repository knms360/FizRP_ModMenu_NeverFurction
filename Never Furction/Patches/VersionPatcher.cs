using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Never_Furction.Patches
{
    [HarmonyPatch(typeof(TitleScript))]
    internal class VersionPatcher
    {
        [HarmonyPatch("Start")]
        [HarmonyPostfix]
        static void versionpatch(ref UnityEngine.UI.Text ___versionTex)
        {
            ___versionTex.text = "NeverFurction v0.4 Enabled!\nOriginal " + ___versionTex.text;
        }
    }
}
