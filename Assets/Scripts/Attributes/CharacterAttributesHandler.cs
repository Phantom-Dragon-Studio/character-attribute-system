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
    public ICharacterAttribute Agility => myAttributes[AttributeType.Agility];
    public ICharacterAttribute Strength => myAttributes[AttributeType.Strength];
    public ICharacterAttribute Wisdom => myAttributes[AttributeType.Wisdom];
    public ICharacterAttribute Endurance => myAttributes[AttributeType.Endurance];

    public void UpdateAllAttributes(ICharacterAttribute[] attributes)
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            myAttributes[attributes[i].AttributeType].Amount += attributes[i].Amount;
        }
    }

    public void UpdateAtribute(AttributeType type, float amount)
    {
        myAttributes[type].Amount += amount;
    }

    public void AddAttribute(ICharacterAttribute attribute)
    {
        if (!myAttributes.ContainsKey(attribute.AttributeType))
        {
            myAttributes.Add(attribute.AttributeType, CharacterAttributeFactory.Create(attribute.AttributeType, attribute.Amount));
        }
    }
}