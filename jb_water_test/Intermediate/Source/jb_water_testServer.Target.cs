using UnrealBuildTool;

public class jb_water_testServerTarget : TargetRules
{
	public jb_water_testServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("jb_water_test");
	}
}
