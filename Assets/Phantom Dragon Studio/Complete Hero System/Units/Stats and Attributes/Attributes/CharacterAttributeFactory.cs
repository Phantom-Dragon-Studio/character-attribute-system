﻿using Phantom_Dragon_Studio.Tools;

namespace Phantom_Dragon_Studio.Hero_System
{
    public static class CharacterAttributeFactory
    {
        public static ICharacterAttribute Create(AttributeType attributeType, float value)
        {
            CharacterAttribute newAttribute = new CharacterAttribute(new TypeValuePair<AttributeType, float>(attributeType, value));

            newAttribute.AttributeInfo.type = attributeType;
            newAttribute.AttributeInfo.value = value;

            return newAttribute;
        }
    }
}
