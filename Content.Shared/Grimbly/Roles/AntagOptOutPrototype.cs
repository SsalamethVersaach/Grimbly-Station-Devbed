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
    ///     Whether or not the player can set the antag role in antag opt out preferences.
    /// </summary>
    [DataField("setPreference")]
    public bool SetPreference { get; private set; }

/// <summary>
    ///    description of opt out
    /// </summary>
    [DataField("description")]
    public string Description {get; private set; } = "";
    // public string Description { get=> description;  set => description = value ?? throw new ArgumentNullException("Description is required."); }


    /// <summary>
    ///     Level of Target
    /// </summary>
    [DataField("antagonistTarget")]
    public int antagonistTarget { get; private set; }


    /// <summary>
    ///     Requirements that must be met to opt in to this antag role.
    /// </summary>
    // TODO ROLE TIMERS
    // Actually check if the requirements are met. Because apparently this is actually unused.
    [DataField, Access(typeof(SharedRoleSystem), Other = AccessPermissions.None)]
    public HashSet<JobRequirement>? Requirements;

    /*- type: antagOptOut
  id: optKill
  name: Kill (Non Round Removal)
  description: Opt in for Dying (Non Round Removal by Traitors)
  antagonistTarget: 1
  setPreference: true

- type: antagOptOut
  id: optRR
  name: Round Removal
  description: Opt In For Round Removal (Traitors)
  antagonistTarget: 0
  setPreference: true

- type: antagOptOut
  id: optMean
  name: Teach You A Lesson
  description: You seem to have mildly irritated the Syndicate! (Opt In For Thief Target/Annoyance)
  antagonistTarget: 2
  setPreference: true

- type: antagOptOut
  id: optNone
  name: None
  description: Opt Out For All (Traitor) Antag Targeting
  antagonistTarget: 3
  setPreference: true

*/


    /// <summary>
    /// Optional list of guides associated with this antag. If the guides are opened, the first entry in this list
    /// will be used to select the currently selected guidebook.
    /// </summary>
    [DataField]
    public List<ProtoId<GuideEntryPrototype>>? Guides;
}
