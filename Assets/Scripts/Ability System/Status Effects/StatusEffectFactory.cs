using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatusEffectFactory
{
    public static IStatusEffect Create(AbilityInformation abilityInfo)
    {
        IStatusEffect newAbility = new StatusEffect(abilityInfo);

        return newAbility;
    }
}