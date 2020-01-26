using System.Collections.Generic;

/// <summary>
/// This class manages all Elemental Resistances on a given unit. This hsould allow for easy management of the effects each unit has on it at the time.
/// Allowing for stacking of effects.
/// </summary>

public class ElementalResistanceHandler : IElementalResistanceHandler
{
    private const float DefaultValue = 10f; //TODO Default to 0
    private Dictionary<ElementalEffectType, IElementalResistance> ResistanceTypes { get; } = new Dictionary<ElementalEffectType, IElementalResistance>();

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
        ResistanceTypes[typeToUpdate].ResistanceInfo.value += amount;
    }

    public IElementalResistance GetResistanceByType(ElementalEffectType typeToCheck)
    {
        if (ResistanceTypes.ContainsKey(typeToCheck)) return ResistanceTypes[typeToCheck];
        AddResistance(typeToCheck, DefaultValue);
        return ResistanceTypes[typeToCheck];
    }
}