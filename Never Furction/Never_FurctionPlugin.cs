using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Never_Furction.Patches;
using System.ComponentModel;
using UnityEngine;

namespace Never_Furction
{
    // TODO Review this file and update to your own requirements.

    [BepInPlugin(MyGUID, PluginName, VersionString)]
    public class Never_FurctionPlugin : BaseUnityPlugin
    {
        // Mod specific details. MyGUID should be unique, and follow the reverse domain pattern
        // e.g.
        // com.mynameororg.pluginname
        // Version should be a valid version string.
        // e.g.
        // 1.0.0
        private const string MyGUID = "com.knms360.Never_Furction";
        private const string PluginName = "Never_Furction";
        private const string VersionString = "0.4.0.0";

        // Config entry key strings
        // These will appear in the config file created by BepInEx and can also be used
        // by the OnSettingsChange event to determine which setting has changed.
        public static string FloatExampleKey = "Float Example Key";
        public static string IntExampleKey = "Int Example Key";
        public static string KeyboardShortcutExampleKey = "Recall Keyboard Shortcut";
        public static string infjumpkey = "Infinity Jump";
        public static string hammerkey = "Super Hammer";
        public static string theworldkey = "The World";
        public static string immortalkey = "Immortal";

        // Configuration entries. Static, so can be accessed directly elsewhere in code via
        // e.g.
        // float myFloat = Never_FurctionPlugin.FloatExample.Value;
        // TODO Change this code or remove the code if not required.
        public static ConfigEntry<float> FloatExample;
        public static ConfigEntry<int> IntExample;
        public static ConfigEntry<KeyboardShortcut> KeyboardShortcutExample;
        public static ConfigEntry<bool> infjumpchk;
        public static ConfigEntry<bool> hammerchk;
        public static ConfigEntry<string> instantgoalbutton;
        public static ConfigEntry<bool> theworldchk;
        public static float Floatsave;
        public static ConfigEntry<bool> immortalchk;
        public static ConfigEntry<ItemList> Gravitylist { get; set; }
        public static ConfigEntry<string> anywheredoorbutton;
        public static ConfigEntry<bool> MPHPRifeCoinControllchk;
        public static ConfigEntry<int> coin;
        public static ConfigEntry<int> life;
        public static ConfigEntry<int> hp;
        public static ConfigEntry<int> mp;
        public static ConfigEntry<bool> spdchk;
        public static ConfigEntry<float> spd;
        public static ConfigEntry<bool> jumppowerchk;
        public static ConfigEntry<float> jump;
        public static ConfigEntry<bool> turboattackchk;
        public static ConfigEntry<bool> GenocideWalkchk;
        public static bool clocker = false;
        public static ConfigEntry<bool> setknockbackchk;
        public static ConfigEntry<float> knockback;
        public static ConfigEntry<bool> playersizechangechk;
        public static ConfigEntry<float> size;

        private static readonly Harmony Harmony = new Harmony(MyGUID);
        public static ManualLogSource Log = new ManualLogSource(PluginName);

        public enum ItemList
        {
            [Description("Earth")]
            EARTH,

            [Description("Moon")]
            MOON,

            [Description("Sun")]
            SUN,

            [Description("Zero")]
            ZERO,

            [Description("Reverce")]
            REVERCE
        }

        /// <summary>
        /// Initialise the configuration settings and patch methods
        /// </summary>
        private void Awake()
        {
            // Float configuration setting example
            // TODO Change this code or remove the code if not required.
            /*            FloatExample = Config.Bind("General",    // The section under which the option is shown
                            FloatExampleKey,                            // The key of the configuration option
                            1.0f,                            // The default value
                            new ConfigDescription("Example float configuration setting.",         // Description that appears in Configuration Manager
                                new AcceptableValueRange<float>(0.0f, 10.0f)));     // Acceptable range, enabled slider and validation in Configuration Manager

                        // Int setting example
                        // TODO Change this code or remove the code if not required.
                        IntExample = Config.Bind("General",
                            IntExampleKey,
                            1,
                            new ConfigDescription("Example int configuration setting.",
                                new AcceptableValueRange<int>(0, 10)));

                        // Keyboard shortcut setting example
                        // TODO Change this code or remove the code if not required.
                        KeyboardShortcutExample = Config.Bind("General",
                            KeyboardShortcutExampleKey,
                            new KeyboardShortcut(KeyCode.A, KeyCode.LeftControl));
            */

            infjumpchk = Config.Bind("-----------Player-----------", infjumpkey, false, new ConfigDescription("You can jump infinitely."));     // Acceptable range, enabled slider and validation in Configuration Manager
            hammerchk = Config.Bind("-----------Cyan-----------", hammerkey, false, new ConfigDescription("The hammer becomes huge."));     // Acceptable range, enabled slider and validation in Configuration Manager
            instantgoalbutton = Config.Bind(
                "-----------General-----------",
                "Key",
                "",
                new ConfigDescription(
                    "",
                    null,
                    new ConfigurationManagerAttributes
                    {
                        DispName = "Instant Win",
                        HideDefaultButton = true,
                        Order = 0,
                        CustomDrawer = (ConfigEntryBase entry) =>
                        {
                            GUILayout.BeginVertical();
                            if (GUILayout.Button("Win", GUILayout.ExpandWidth(true)))
                            {
                                //Debug.Log(instantgoalbutton.Value);
                                instantgoalbutton.Value = "true";
                            }
                            GUILayout.EndVertical();
                        }
                    }
                    )
                );
            theworldchk = Config.Bind("-----------General-----------", theworldkey, false, new ConfigDescription("Dio:The World! Stop Time!"));     // Acceptable range, enabled slider and validation in Configuration Manager
            immortalchk = Config.Bind("-----------Player-----------", immortalkey, false, new ConfigDescription("No deaths from falling."));     // Acceptable range, enabled slider and validation in Configuration Manager
            Gravitylist = Config.Bind("-----------Player-----------", "Gravity", ItemList.EARTH, "You can change gravity.");
            anywheredoorbutton = Config.Bind(
    "-----------General-----------",
    "Key2",
    "",
    new ConfigDescription(
        "",
        null,
        new ConfigurationManagerAttributes
        {
            DispName = "Anywere Door",
            HideDefaultButton = true,
            Order = 0,
            CustomDrawer = (ConfigEntryBase entry) =>
            {
                GUILayout.BeginVertical();
                if (GUILayout.Button("Next Door", GUILayout.ExpandWidth(true)))
                {
                    anywheredoorbutton.Value = "1";
                }
                if (GUILayout.Button("StageSelect Door", GUILayout.ExpandWidth(true)))
                {
                    anywheredoorbutton.Value = "2";
                }
                GUILayout.EndVertical();
            }
        }
        )
    );
            MPHPRifeCoinControllchk = Config.Bind("-----------General-----------", "Fix Parameter", false, new ConfigDescription("Stack HP, MP, Coin, Life."));     // Acceptable range, enabled slider and validation in Configuration Manager
            coin = Config.Bind("-----------General-----------", "Fix Parameter:Coin", 99, new ConfigDescription("Coin", new AcceptableValueRange<int>(0, 999)));
            life = Config.Bind("-----------General-----------", "Fix Parameter:Rest", 99, new ConfigDescription("Rest", new AcceptableValueRange<int>(0, 999)));
            hp = Config.Bind("-----------General-----------", "Fix Parameter:Life", 100, new ConfigDescription("Life: By setting it to 1001, you can get the same power as Immortal.", new AcceptableValueRange<int>(0, 1001)));
            mp = Config.Bind("-----------General-----------", "Fix Parameter:SP", 100, new ConfigDescription("SP", new AcceptableValueRange<int>(0, 350)));
            spdchk = Config.Bind("-----------Player-----------", "Speed Hack", false, new ConfigDescription("Increase movement speed."));
            spd = Config.Bind("-----------Player-----------", "Speed Hack:Speed", 20f, new ConfigDescription("Speed", new AcceptableValueRange<float>(0f, 100f)));
            jumppowerchk = Config.Bind("-----------Player-----------", "Jump Power", false, new ConfigDescription("Increases jump height."));
            jump = Config.Bind("-----------Player-----------", "Jump Power:Height", 20f, new ConfigDescription("Height", new AcceptableValueRange<float>(0f, 100f)));
            turboattackchk = Config.Bind("-----------General-----------", "Turbo X Key", false, new ConfigDescription("Automatically press X key."));
            GenocideWalkchk = Config.Bind("-----------Player-----------", "Genocide Walk", false, new ConfigDescription("Flip left and right multiple times."));
            setknockbackchk = Config.Bind("-----------Player-----------", "Set Knockback", false, new ConfigDescription("Change knockback power."));
            knockback = Config.Bind("-----------Player-----------", "Set Knockback:Knockback", 10f, new ConfigDescription("Knockback direction", new AcceptableValueRange<float>(-20f, 20f)));
            playersizechangechk = Config.Bind("-----------Player-----------", "Change Player Size", false, new ConfigDescription("The player becomes huge."));
            size = Config.Bind("-----------Player-----------", "Change Player Size:Size", 1f, new ConfigDescription("Player size: Set it to 0 for noclip.", new AcceptableValueRange<float>(-20f, 100f)));

            // Add listeners methods to run if and when settings are changed by the player.
            // TODO Change this code or remove the code if not required.
            /*            FloatExample.SettingChanged += ConfigSettingChanged;
                        IntExample.SettingChanged += ConfigSettingChanged;
                        KeyboardShortcutExample.SettingChanged += ConfigSettingChanged;*/

            // Apply all of our patches
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loading...");
            Harmony.PatchAll();
            Logger.LogInfo($"PluginName: {PluginName}, VersionString: {VersionString} is loaded.");

            // Sets up our static Log, so it can be used elsewhere in code.
            // .e.g.
            // Never_FurctionPlugin.Log.LogDebug("Debug Message to BepInEx log file");
            Log = Logger;
        }

        /// <summary>
        /// Code executed every frame. See below for an example use case
        /// to detect keypress via custom configuration.
        /// </summary>
        // TODO - Add your code here or remove this section if not required.
/*        private void Update()
        {
            if (Never_FurctionPlugin.KeyboardShortcutExample.Value.IsDown())
            {
                // Code here to do something on keypress
                Logger.LogInfo("Keypress detected!");
            }
        }
*/
        /// <summary>
        /// Method to handle changes to configuration made by the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
/*        private void ConfigSettingChanged(object sender, System.EventArgs e)
        {
            SettingChangedEventArgs settingChangedEventArgs = e as SettingChangedEventArgs;

            // Check if null and return
            if (settingChangedEventArgs == null)
            {
                return;
            }

            // Example Float Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == FloatExampleKey)
            {
                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
                Harmony.UnpatchAll();
            }

            // Example Int Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == IntExampleKey)
            {
            }

            // Example Keyboard Shortcut setting changed handler
            if (settingChangedEventArgs.ChangedSetting.Definition.Key == KeyboardShortcutExampleKey)
            {
                KeyboardShortcut newValue = (KeyboardShortcut)settingChangedEventArgs.ChangedSetting.BoxedValue;

                // TODO - Add your code here or remove this section if not required.
                // Code here to do something with the new value
            }

        }*/
    }
}
