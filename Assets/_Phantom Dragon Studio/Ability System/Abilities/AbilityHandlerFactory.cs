﻿using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    /// <summary>
    /// A Null reference exception can be thrown by the AddAbility line if the CharacterLeague sends an attribute with a null value
    /// </summary>
    public static class AbilityHandlerFactory
    {
        public static IAbilityHandler Create(IAbility[] abilities, AbilityController abilityController)
        {
            var newAbilityHandler = new AbilityHandler();
            if (abilities != null)
            {
                for (int i = 0; i < abilities.Length; i++)
                {
                    abilities[i].Initialize(abilityController);
                    newAbilityHandler.AddAbility(i, abilities[i]);
                }
            }
            else Debug.LogError("Null list received by AbilityHandler Factory.");

            return newAbilityHandler;
        }
    }
}
