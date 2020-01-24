using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class manages all Elemental Resistances on a given unit. This hsould allow for easy management of the effects each unit has on it at the time.
/// Allowing for stacking of effects.
/// </summary>

public class ElementalResistanceHandler : IElementalResistanceHandler
{
    private Dictionary<ElementalEffectType, IElementalResistance> resistanceTypes = new Dictionary<ElementalEffectType, IElementalResistance>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<ElementalEffectType, IElementalResistance> ResistanceTypes { get => resistanceTypes; }

    public IElementalResistance Fire => ResistanceTypes[ElementalEffectType.Fire];
    public IElementalResistance Water => ResistanceTypes[ElementalEffectType.Water];
    public IElementalResistance Earth => ResistanceTypes[ElementalEffectType.Earth];
    public IElementalResistance Wind => ResistanceTypes[ElementalEffectType.Wind];
    public IElementalResistance Lightning => ResistanceTypes[ElementalEffectType.Lightning];
    public IElementalResistance Divine => ResistanceTypes[ElementalEffectType.Divine];
    public IElementalResistance Dark => ResistanceTypes[ElementalEffectType.Dark];
    public IElementalResistance Arcane => ResistanceTypes[ElementalEffectType.Arcane];

    public void AddResistance(ElementalEffectType typeToAdd, float amount)
    {
        if (!ResistanceTypes.ContainsKey(typeToAdd))
        {
            ResistanceTypes.Add(typeToAdd, ElementalResistanceFactory.Create(typeToAdd, amount));
        }
    }

    public void UpdateIndividualResistance(ElementalEffectType typeToUpdate, float amount)
    {
        ResistanceTypes[typeToUpdate].ResistanceInfo.Value += amount;
    }

    public float GetResistanceValue(ElementalEffectType typeToCheck)
    {
        return resistanceTypes[typeToCheck].ResistanceInfo.Value;
    }
}