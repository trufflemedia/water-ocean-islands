using UnrealBuildTool;

public class jb_water_testClientTarget : TargetRules
{
	public jb_water_testClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("jb_water_test");
	}
}
