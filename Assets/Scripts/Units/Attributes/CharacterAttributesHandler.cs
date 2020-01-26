using System;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class manages all attributes on a given unit class. This is done to avoid unwanted changes to the attributes as well as seperated concerns.
/// </summary>

public class CharacterAttributesHandler : ICharacterAttributesHandler
{
    private Dictionary<AttributeType, ICharacterAttribute> Attributes { get; } = new Dictionary<AttributeType, ICharacterAttribute>();
    public ICharacterAttribute Agility => Attributes[AttributeType.Agility];
    public ICharacterAttribute Strength => Attributes[AttributeType.Strength];
    public ICharacterAttribute Wisdom => Attributes[AttributeType.Wisdom];
    public ICharacterAttribute Endurance => Attributes[AttributeType.Endurance];

    public void UpdateAttribute(TypeValuePair<AttributeType, float> attribute)
    {
        Attributes[attribute.type].UpdateValue(attribute.value);
    }

    public void AddAttribute(TypeValuePair<AttributeType, float> attribute)
    {
        if (!Attributes.ContainsKey(attribute.type))
        {
            var temp = CharacterAttributeFactory.Create(attribute.type, attribute.value);
            Attributes.Add(temp.AttributeInfo.type, temp);
        }
    }
}