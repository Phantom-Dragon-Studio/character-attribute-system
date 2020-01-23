using UnityEngine;

public interface IStatusEffectHandler
{
    void AddStatusEffect(ICharacterAttribute attribute);

    IStatusEffect[] GetAllStatusEffectsOfType(PhysicalStatusEffectType statusEffectType);

    IStatusEffect[] GetAllStatusEffects(IStatusEffect[] currentlyActiveEffects);
}
