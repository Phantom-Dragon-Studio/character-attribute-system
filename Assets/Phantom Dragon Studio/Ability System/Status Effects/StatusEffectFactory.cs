using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StatusEffectFactory
{
    public static IStatusEffect Create(PhysicalStatusEffectType typeToCreate)
    {
        IStatusEffect newStatusEffect = new StatusEffect();

        return newStatusEffect;
    }
}