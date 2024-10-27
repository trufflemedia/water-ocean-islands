using UnrealBuildTool;

public class jb_water_testTarget : TargetRules
{
	public jb_water_testTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("jb_water_test");
	}
}
