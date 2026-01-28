using HarmonyLib;
using Il2CppQuantum;

namespace WindblownCharacterUnlocker;

/*[HarmonyPatch(typeof(PlayerMeta), nameof(PlayerMeta.HasValidSpecies), MethodType.Getter)]
public static class PlayerMeta_HasValidSpecies
{
    public static bool Prefix(ref PlayerMeta __instance)
    {
        //CharacterUnlockerMod.Instance.Logger.Msg("PlayerMeta.HasValidSpecies called...");
        __instance.flags.Add(MetaFlag.PerpetualFlagAlphaPlayer);
        __instance.flags.Add(MetaFlag.PerpetualFlagDemoPlayer);
        __instance.flags.Add(MetaFlag.PerpetualFlagSuperEarlyAccessPlayer);
        __instance.ApplyPerpetualFlagsEffects();
        return true;
    }
}*/

[HarmonyPatch(typeof(PlayerSpeciesData), nameof(PlayerSpeciesData.IsAvailable))]
public static class PlayerSpeciesData_IsAvailable
{
    public static bool Prefix(ref bool __result)
    {
        __result = true;
        return false;
    }
}

/*[HarmonyPatch(typeof(UnlockSummary), nameof(UnlockSummary.Current), MethodType.Getter)]
public static class UnlockSummary_Current
{
    public static bool Prefix(UnlockSummary __instance, ref int __result)
    {
        __result = __instance.Total;
        return false;
    }
}*/