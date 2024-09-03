using JetBrains.Annotations;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared.Grimbly.Roles;

public abstract partial class AntagonistOptOutRoleComponent : Component
{
    [DataField("prototype", required: true, customTypeSerializer: typeof(PrototypeIdSerializer<AntagOptOutPrototype>))]
    public string? PrototypeId;
}

/// <summary>
/// Mark the antagonist opt out role component as being exclusive
/// IE by default other antagonist opt outs should refuse to select the same entity for a different opt out state
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
[BaseTypeRequired(typeof(AntagonistOptOutRoleComponent))]
public sealed partial class ExclusiveAntagonistOptOutAttribute : Attribute
{
}
