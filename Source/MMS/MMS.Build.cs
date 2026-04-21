// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MMS : ModuleRules
{
	public MMS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"OnlineSubsystem",
			"OnlineSubsystemSteam"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MMS",
			"MMS/Variant_Platforming",
			"MMS/Variant_Platforming/Animation",
			"MMS/Variant_Combat",
			"MMS/Variant_Combat/AI",
			"MMS/Variant_Combat/Animation",
			"MMS/Variant_Combat/Gameplay",
			"MMS/Variant_Combat/Interfaces",
			"MMS/Variant_Combat/UI",
			"MMS/Variant_SideScrolling",
			"MMS/Variant_SideScrolling/AI",
			"MMS/Variant_SideScrolling/Gameplay",
			"MMS/Variant_SideScrolling/Interfaces",
			"MMS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
