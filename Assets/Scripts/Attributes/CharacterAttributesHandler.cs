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
    public ICharacterAttribute Agility => MyAttributes[AttributeType.Agility];
    public ICharacterAttribute Strength => MyAttributes[AttributeType.Strength];
    public ICharacterAttribute Wisdom => MyAttributes[AttributeType.Wisdom];
    public ICharacterAttribute Endurance => MyAttributes[AttributeType.Endurance];

    public Dictionary<AttributeType, ICharacterAttribute> MyAttributes { get => myAttributes; }


    //Unit Testing Purposes
    ICharacterAttribute[] ICharacterAttributesHandler.MyAttributes => throw new NotImplementedException();

    public void UpdateAllAttributes(ICharacterAttribute[] attributes)
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            MyAttributes[attributes[i].AttributeType].Amount += attributes[i].Amount;
        }
    }

    public void UpdateAtribute(AttributeType type, float amount)
    {
        MyAttributes[type].Amount += amount;
    }

    public void AddAttribute(ICharacterAttribute attribute)
    {
        if (!MyAttributes.ContainsKey(attribute.AttributeType))
        {
            MyAttributes.Add(attribute.AttributeType, CharacterAttributeFactory.Create(attribute.AttributeType, attribute.Amount));
        }
    }
}