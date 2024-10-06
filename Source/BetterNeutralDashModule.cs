using System;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.BetterNeutralDash;

public class BetterNeutralDashModule : EverestModule
{
    private static BetterNeutralDashModule Instance { get; set; }

    public override Type SettingsType => typeof(BetterNeutralDashModuleSettings);
    private static BetterNeutralDashModuleSettings Settings => (BetterNeutralDashModuleSettings)Instance._Settings;

    public BetterNeutralDashModule()
    {
        Instance = this;
    }

    public override void Load()
    {
        On.Celeste.Input.GetAimVector += InputOnGetAimVector;
    }

    public override void Unload()
    {
        On.Celeste.Input.GetAimVector -= InputOnGetAimVector;
    }

    private static Vector2 InputOnGetAimVector(On.Celeste.Input.orig_GetAimVector orig, Facings defaultfacing)
    {
        return (Settings.BetterNeutralDash && Input.Aim.Value == Vector2.Zero) ? Input.LastAim : orig(defaultfacing);
    }
}