using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Note: A Null reference exception can be thrown by the AddAttribute line if the character sheet sends an attribute with a null value

public static class CharacterAttributesHandlerFactory
{
    public static ICharacterAttributesHandler Create(ICharacterAttribute[] attributes)
    {
        var newAttributeHandler = new CharacterAttributesHandler();
        if (attributes != null)
        {
            for (int i = 0; i < attributes.Length; i++)
            {
                newAttributeHandler.AddAttribute(attributes[i]);
            }
        }
        else Debug.LogError("Null list recieved by CharacterAttributesHandler Factory.");

        return newAttributeHandler;
    }
}
