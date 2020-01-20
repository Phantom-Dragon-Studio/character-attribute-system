using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectHandler : MonoBehaviour
{
    private IElementalResistanceHandler elementalResistanceHandler;

    private Dictionary<ElementalEffectType, IElementalResistance> resistances = new Dictionary<ElementalEffectType, IElementalResistance>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<ElementalEffectType, IElementalResistance> ResistanceTypes { get => resistances; }
    public IElementalResistance Fire => ResistanceTypes[ElementalEffectType.Fire];
    public IElementalResistance Water => ResistanceTypes[ElementalEffectType.Water];
    public IElementalResistance Earth => ResistanceTypes[ElementalEffectType.Earth];
    public IElementalResistance Wind => ResistanceTypes[ElementalEffectType.Wind];
    public IElementalResistance Lightning => ResistanceTypes[ElementalEffectType.Lightning];
    public IElementalResistance Divine => ResistanceTypes[ElementalEffectType.Divine];
    public IElementalResistance Dark => ResistanceTypes[ElementalEffectType.Dark];
    public IElementalResistance Arcane => ResistanceTypes[ElementalEffectType.Arcane];


    public void AddResistance(IElementalResistance elementalResistance)
    {
        if (!ResistanceTypes.ContainsKey(elementalResistance.ElementalType))
        {
            ResistanceTypes.Add(elementalResistance.ElementalType, ElementalResistanceFactory.Create(elementalResistance.ElementalType, elementalResistance.Amount));
        }
    }

    public void UpdateIndividualResistance(ElementalEffectType type, float amount)
    {
        ResistanceTypes[type].Amount += amount;
    }

    public void UpdateAllResistances(IElementalResistance[] resistances)
    {
        for (int i = 0; i < resistances.Length; i++)
        {
            ResistanceTypes[resistances[i].ElementalType].Amount += resistances[i].Amount;
        }
    }
}
