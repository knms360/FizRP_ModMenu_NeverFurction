using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Never_Furction.Patches
{
    [HarmonyPatch(typeof(ActionSceneManager))]
    internal class ChangeSizePlayer
    {
        [HarmonyPatch("Update")]
        [HarmonyPrefix]
        static void playersizepatch(ref List<PlayerBase> ___players, ref int ___charactorIndex)
        {
            Debug.Log(___players[___charactorIndex].transform.localScale);
            if (Never_FurctionPlugin.playersizechangechk.Value)
            {
                float size = Never_FurctionPlugin.size.Value;
                ___players[___charactorIndex].transform.localScale = new Vector3(size, size, size);
            }
        }
    }
}
