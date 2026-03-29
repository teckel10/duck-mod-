using SPTarkov.Server.Core.Models.Spt.Mod;
using Range = SemanticVersioning.Range;
using Version = SemanticVersioning.Version;

namespace duck;

public record metadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.teckel.duck";
    public override string Name { get; init; } = "duck!";
    public override string Author { get; init; } = "teckel.duck";
    public override List<string>? Contributors { get; init; } = null;
    public override Version Version { get; init; } = new Version("1.0.0");
    public override Range SptVersion { get; init; } = new Range("~4.0.13");
    public override List<string>? Incompatibilities { get; init; } = null;
    public override Dictionary<string, Range>? ModDependencies { get; init; } = null;
    public override string? Url { get; init; } =null;
    public override bool? IsBundleMod { get; init; } = true;
    public override string License { get; init; } = "MIT";
}