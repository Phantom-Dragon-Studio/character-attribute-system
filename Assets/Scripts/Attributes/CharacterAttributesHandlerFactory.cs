using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttributesHandlerFactory
{
    public ICharacterAttributesHandler Create(ICharacterAttribute[] attributes)
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
