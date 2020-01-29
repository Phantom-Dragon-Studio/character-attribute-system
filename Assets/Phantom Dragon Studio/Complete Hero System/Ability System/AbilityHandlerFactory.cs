using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A Null reference exception can be thrown by the AddAbility line if the CharacterLeague sends an attribute with a null value
/// </summary>
public static class AbilityHandlerFactory
{
    public static IAbilityHandler Create(AbilityInformation[] abilities)
    {
        var newAbilityHandler = new AbilityHandler();
        if (abilities != null)
        {
            for (int i = 0; i < abilities.Length; i++)
            {
                newAbilityHandler.AddAbility(i, AbilityFactory.Create(abilities[i]));
            }
        }
        else Debug.LogError("Null list recieved by AbilityHandler Factory.");

        return newAbilityHandler;
    }
}
