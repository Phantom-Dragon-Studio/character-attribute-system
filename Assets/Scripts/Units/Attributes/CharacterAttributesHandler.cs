using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class manages all attributes on a given unit class. This is done to avoid unwanted changes to the attributes as well as seperated concerns.
/// </summary>

public class CharacterAttributesHandler : ICharacterAttributesHandler
{
    private Dictionary<AttributeType, ICharacterAttribute> myAttributes = new Dictionary<AttributeType, ICharacterAttribute>();

    //Any Getters & Setters added here for attributes will need to be added into the ICharacterAttribute Interface & Class as well for accessibility.
    public Dictionary<AttributeType, ICharacterAttribute> Attributes { get => myAttributes; }

    public ICharacterAttribute Agility => Attributes[AttributeType.Agility];
    public ICharacterAttribute Strength => Attributes[AttributeType.Strength];
    public ICharacterAttribute Wisdom => Attributes[AttributeType.Wisdom];
    public ICharacterAttribute Endurance => Attributes[AttributeType.Endurance];

    public void UpdateAllAttributes(ICharacter character, ICharacterAttribute[] attributes)
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            Attributes[attributes[i].AttributeType].UpdateValue(character, attributes[i].Amount);
        }
    }

    public void UpdateAtribute(ICharacter character, AttributeType type, float amount)
    {
        Attributes[type].UpdateValue(character, amount);
    }

    public void AddAttribute(ICharacterAttribute attribute)
    {
        if (!Attributes.ContainsKey(attribute.AttributeType))
        {
            Attributes.Add(attribute.AttributeType, CharacterAttributeFactory.Create(attribute.AttributeType, attribute.Amount));
        }
    }
}