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
    [HarmonyPatch(typeof(Player_Fiz))]
    internal class SuperHammer
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("AttackFunc")]
        [HarmonyPostfix]
        static void hammerpatch(ref PlayerBase __instance, ref Rigidbody2D ___rb2d, ref GameObject ___specialAttackPrefab, ref GameObject ___spriteObject,ref InControl.InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.hammerchk.Value)
            {
                if (MyControlExpantion.GetDashButtonDown(___activeDevice))
                {
                    GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(___specialAttackPrefab);
                    gameObject2.transform.position = __instance.transform.position + new Vector3(___spriteObject.transform.localScale.x * 0.5f, 0.15f, 0f);
                    gameObject2.transform.localScale = new Vector3(5f, 5f, 5f);
                    Rigidbody2D component2 = gameObject2.GetComponent<Rigidbody2D>();
                    component2.velocity = ___rb2d.velocity;
                    component2.gravityScale = 2f;
                    component2.AddForce(new Vector2(___spriteObject.transform.localScale.x, 3f) * 6f, ForceMode2D.Impulse);
                }
            }
        }

        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Fiz_3D))]
    internal class SuperHammer3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("AttackFunc")]
        [HarmonyPostfix]
        static void hammerpatch(ref PlayerBase __instance, ref float ___speed, ref Rigidbody ___rb, ref MoveObjectScript ___moveObjectScript, ref GameObject ___attackPrefab, ref GameObject ___spriteObject, ref InControl.InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.hammerchk.Value)
            {
                if (MyControlExpantion.GetDashButtonDown(___activeDevice))
                {
                    GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(___attackPrefab);
                    HammerScript3D component = gameObject.GetComponent<HammerScript3D>();
                    gameObject.transform.position = __instance.transform.position + new Vector3(___spriteObject.transform.localScale.x * 0.5f, 0.15f, 0f);
                    gameObject.transform.localScale = new Vector3(5f, 5f, 5f);
                    component.Set3dPosition(___moveObjectScript.GetStageLineScript(), ___moveObjectScript.GetNowSectionPos() + ___spriteObject.transform.localScale.x * 0.5f);
                    Rigidbody component2 = gameObject.GetComponent<Rigidbody>();
                    component2.velocity = ___rb.velocity + new Vector3(___speed, 0f, 0f);
                    component.SetSpeedX(___speed + ___spriteObject.transform.localScale.x * 6f);
                    component2.AddForce(new Vector2(___spriteObject.transform.localScale.x, 3f) * 6f, ForceMode.Impulse);
                }
            }
        }

        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
}