using System;
using System.Collections.Generic;
using UnityEngine;

public enum AttributeType
{
    //Note: Any items added or removed in this Enum should also be updates to reflect inside the CharacterAttributes constructor.
    Agility,
    Strength,
    Wisdom,
    Endurance,
}


public class CharacterAttributes : IAttribute
{

    private Dictionary<AttributeType, Attribute> myAttributes = new Dictionary<AttributeType, Attribute>();

    //Any Getters & Setters added here for attributes will need to be added into the IAttribute interface as well for accessibility.
    public Attribute Agility { get; internal set; }
    public Attribute Strength { get; internal set; }
    public Attribute Wisdom { get; internal set; }
    public Attribute Endurance { get; internal set; }

    public CharacterAttributes(Attribute[] attributes)
    {
        if (attributes != null)
        {
            for (int i = 0; i < attributes.Length; i++)
            {
                if (!myAttributes.ContainsKey(attributes[i].AttributeType))
                {
                    myAttributes.Add(attributes[i].AttributeType, new Attribute(attributes[i].AttributeType, attributes[i].Amount));
                }
                else
                {
                    Debug.Log("Whoops! You tried to add something with the same key to the CharacterAttribute dictionary twice! Check your CharacterSheet file.");
                }
            }
            try
            {
                Agility = myAttributes[AttributeType.Agility];
                Strength = myAttributes[AttributeType.Strength];
                Wisdom = myAttributes[AttributeType.Wisdom];
                Endurance = myAttributes[AttributeType.Endurance];
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                Debug.Log("Key not found! Character Sheet provided to CharacterAttributes has missing attributes!");
            }
        }
        else Debug.LogWarning("Null list recieved by CharacterAttributes class.");
    }

    public void UpdateAllAttributes(Attribute[] attributes)
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
}