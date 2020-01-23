using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectHandler : IStatusEffectHandler
{
    private IElementalResistanceHandler elementalResistanceHandler;

    private Dictionary<PhysicalStatusEffectType, IStatusEffect> resistances = new Dictionary<PhysicalStatusEffectType, IStatusEffect>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<PhysicalStatusEffectType, IStatusEffect> ResistanceTypes { get => resistances; }
    public IStatusEffect Bleeding => ResistanceTypes[PhysicalStatusEffectType.Bleeding];

    public void AddStatusEffect(ICharacterAttribute attribute)
    {
        throw new System.NotImplementedException();
    }

    public IStatusEffect[] GetAllStatusEffectsOfType(PhysicalStatusEffectType statusEffectType)
    {
        throw new System.NotImplementedException();
    }

    public IStatusEffect[] GetAllStatusEffects(IStatusEffect[] currentlyActiveEffects)
    {
        throw new System.NotImplementedException();
    }
}
