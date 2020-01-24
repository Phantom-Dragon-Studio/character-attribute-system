using System.Collections.Generic;
using UnityEngine;

public interface IStatusEffectHandler
{
    void AddStatusEffect(PhysicalStatusEffectType statusEffectType);

    Queue<IStatusEffect> GetAllStatusEffectsOfType(PhysicalStatusEffectType statusEffectType);
}
