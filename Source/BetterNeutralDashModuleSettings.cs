namespace Celeste.Mod.BetterNeutralDash;

public class BetterNeutralDashModuleSettings : EverestModuleSettings {
    [SettingName("Better Neutral Dash"), SettingSubText("Makes neutral dash remember your last direction")]
    public bool BetterNeutralDash { get; set; } = true;
}