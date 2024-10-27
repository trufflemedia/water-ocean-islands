using UnrealBuildTool;

public class jb_water_testEditorTarget : TargetRules
{
	public jb_water_testEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("jb_water_test");
	}
}
