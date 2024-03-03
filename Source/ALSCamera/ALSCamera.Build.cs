using UnrealBuildTool;

public class ALSCamera : ModuleRules
{
	public ALSCamera(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;

		bEnableNonInlinedGenCppWarnings = true;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core", "CoreUObject", "Engine", "GameplayTags", "ALS"
		});

		PrivateDependencyModuleNames.AddRange(new[]
		{
			"EngineSettings"
			"GameplayAbilities"
		});
	}
}
