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

    public void UpdateAtribute(TypeValuePair<AttributeType, float> attribute)
    {
        Attributes[attribute.Type].UpdateValue(attribute.Value);
    }

    public void AddAttribute(TypeValuePair<AttributeType, float> attribute)
    {
        if (!Attributes.ContainsKey(attribute.Type))
        {
            var temp = CharacterAttributeFactory.Create(attribute.Type, attribute.Value);
            Attributes.Add(temp.AttributeInfo.Type, temp);
        }
    }
}