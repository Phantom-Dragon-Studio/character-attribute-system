using UnityEngine;

public interface IStatusEffectHandler
{
    void GetAllStatusEffects(IStatusEffect[] currentlyActiveEffects);

    void AddAttribute(ICharacterAttribute attribute);
}
