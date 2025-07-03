using UnrealBuildTool;
using System.Collections.Generic;

public class ForsakenFutureServerTarget : TargetRules
{
    public ForsakenFutureServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        ExtraModuleNames.AddRange( new string[] { "ForsakenFuture" } );
    }
}
