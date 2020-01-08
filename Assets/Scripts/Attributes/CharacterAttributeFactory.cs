using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterAttributeFactory
{
    public static ICharacterAttribute Create(AttributeType attributeType, float amount)
    {
        CharacterAttribute newAttribute = new CharacterAttribute();

        newAttribute.AttributeType = attributeType;
        newAttribute.Amount = amount;

        return newAttribute;
    }
}
