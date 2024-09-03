using Content.Shared.Guidebook;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization;
using Content.Shared.Roles;

namespace Content.Shared.Grimbly.Roles;

/// <summary>
///     Describes information for a state of Opt Out.
/// </summary>
[Prototype("antagOptOut")]
[Serializable, NetSerializable]
public sealed partial class AntagOptOutPrototype : IPrototype
{
    [ViewVariables]
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    ///     The name of this opt out as displayed to players.
    /// </summary>
    [DataField("name")]
    public string Name { get; private set; } = "";

    /// <summary>
    ///     The level of objective, shown in a tooltip in the antag opt out preference menu or as a ghost role description.
    /// </summary>
    [DataField("objective", required: true)]
    public string Objective { get; private set; } = "";

    /// <summary>
    ///     Whether or not the player can set the antag role in antag opt out preferences.
    /// </summary>
    [DataField("setPreference")]
    public bool SetPreference { get; private set; }

    /// <summary>
    ///     Requirements that must be met to opt in to this antag role.
    /// </summary>
    // TODO ROLE TIMERS
    // Actually check if the requirements are met. Because apparently this is actually unused.
    [DataField, Access(typeof(SharedRoleSystem), Other = AccessPermissions.None)]
    public HashSet<JobRequirement>? Requirements;

    /// <summary>
    /// Optional list of guides associated with this antag. If the guides are opened, the first entry in this list
    /// will be used to select the currently selected guidebook.
    /// </summary>
    [DataField]
    public List<ProtoId<GuideEntryPrototype>>? Guides;
}
