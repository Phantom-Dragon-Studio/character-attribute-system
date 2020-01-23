﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterAttributeFactory
{
    public static ICharacterAttribute Create(AttributeType attributeType, float value)
    {
        CharacterAttribute newAttribute = new CharacterAttribute(new TypeValuePair<AttributeType, float>(attributeType, value));

        newAttribute.AttributeInfo.Type = attributeType;
        newAttribute.AttributeInfo.Value = value;

        return newAttribute;
    }
}
