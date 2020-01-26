using System.Collections.Generic;
using UnityEngine;

public enum PhysicalStatusEffectType
{
    _None = 0,
    Burning,
    Frozen,
    Slowed,
    StaticallyCharged,
    Bleeding,
    Poisoned,
    Corrupted,
    TimedLife,
    Silenced,
    Blinded,
    Rooted,
    Stunned,

}

public interface IStatusEffectHandler
{
    void AddStatusEffect(PhysicalStatusEffectType statusEffectType);

    Queue<IStatusEffect> GetAllStatusEffectsOfType(PhysicalStatusEffectType statusEffectType);
}
