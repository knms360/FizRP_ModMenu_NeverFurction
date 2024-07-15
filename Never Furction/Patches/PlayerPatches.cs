using HarmonyLib;
using InControl;
using JetBrains.Annotations;
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
    internal class PlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Fiz_3D))]
    internal class PlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }





    [HarmonyPatch(typeof(Player_Leafur))]
    internal class LeafurPlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Leafur3D))]
    internal class LeafurPlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }





    [HarmonyPatch(typeof(Player_Kyuma))]
    internal class KyumaPlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Kyuma_3D))]
    internal class KyumaPlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
    }


    [HarmonyPatch(typeof(Player_Rubell))]
    internal class RubellPlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Rubell_3D))]
    internal class RubellPlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
    }

    [HarmonyPatch(typeof(Player_Rythron))]
    internal class RythronPlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Rythron_3D))]
    internal class RythronPlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
    }


    [HarmonyPatch(typeof(Player_Soraco))]
    internal class SoracPlayerPatches
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower, ref InputDevice ___activeDevice)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector2(-1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector2(1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
        /// <summary>
        /// Patches the Player Awake method with postfix code.
        /// </summary>
        /// <param name="__instance"></param>
    }
    [HarmonyPatch(typeof(Player_Soraco_3D))]
    internal class SoracoPlayerPatches3d
    {
        /// <summary>
        /// Patches the Player Awake method with prefix code.
        /// </summary>
        /// <param name="__instance"></param>
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void infjumppatch(ref bool ___isGround)
        {
            if (Never_FurctionPlugin.infjumpchk.Value)
            {
                ___isGround = true;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPrefix]
        static void speedpatch(ref float ___dashSpeed)
        {
            if (Never_FurctionPlugin.spdchk.Value)
            {
                ___dashSpeed = Never_FurctionPlugin.spd.Value;
            }
        }
        [HarmonyPatch("JumpFunc")]
        [HarmonyPrefix]
        static void highjumppatch(ref float ___jumpPower)
        {
            if (Never_FurctionPlugin.jumppowerchk.Value)
            {
                ___jumpPower = Never_FurctionPlugin.jump.Value;
            }
        }
        [HarmonyPatch("HorizontalMove")]
        [HarmonyPostfix]
        static void genocidewalkpatch(ref GameObject ___spriteObject)
        {
            if (Never_FurctionPlugin.GenocideWalkchk.Value)
            {
                if (Never_FurctionPlugin.clocker)
                {
                    ___spriteObject.transform.localScale = new Vector3(-1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = false;
                }
                else
                {
                    ___spriteObject.transform.localScale = new Vector3(1f, 1f, 1f);
                    Never_FurctionPlugin.clocker = true;
                }
            }
        }
        [HarmonyPatch("knockBackStart")]
        [HarmonyPrefix]
        static void flipknockbackpatch(ref float ___knockBackPower)
        {
            if (Never_FurctionPlugin.setknockbackchk.Value)
            {
                ___knockBackPower = Never_FurctionPlugin.knockback.Value;
            }
        }
    }
}