using MelonLoader;
using UnityEngine;
using WindblownCharacterUnlocker;

[assembly: MelonGame("Motion Twin", "Windblown")]
[assembly: MelonInfo(typeof(CharacterUnlockerMod), CharacterUnlockerMod.MOD_NAME, CharacterUnlockerMod.MOD_VERSION, CharacterUnlockerMod.MOD_DEVELOPER, "https://crowdcontrol.live/")]

namespace WindblownCharacterUnlocker;

/// <summary>
/// The main mod class.
/// </summary>
public class CharacterUnlockerMod : MelonMod
{
    // Mod Details
    public const string MOD_GUID = "KatDevsGames.WindblownCharacterUnlocker";
    public const string MOD_DEVELOPER = "KatDevsGames";
    public const string MOD_NAME = "Windblown Character Enabler";
    public const string MOD_VERSION = "1.0.0";

    private readonly HarmonyLib.Harmony harmony = new(MOD_GUID);

    /// <summary>The logger for the mod.</summary>
    public MelonLogger.Instance Logger => LoggerInstance;

    /// <summary>The singleton instance of the game mod.</summary>
    internal static CharacterUnlockerMod Instance { get; private set; } = null!;


    /// <summary>
    /// Called when the mod is created.
    /// </summary>
    public override void OnInitializeMelon()
    {
        Instance = this;

        Logger.Msg($"Loaded {MOD_GUID}. Patching.");
        harmony.PatchAll();
    }
}