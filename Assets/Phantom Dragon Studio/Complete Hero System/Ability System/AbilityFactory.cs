using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AbilityFactory
{
    public static IAbility Create(AbilityInformation abilityInfo)
    {
        IAbility newAbility = new BaseAbility(abilityInfo);

        return newAbility;
    }
}