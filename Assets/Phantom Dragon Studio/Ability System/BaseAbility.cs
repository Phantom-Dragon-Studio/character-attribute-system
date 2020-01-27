using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Json;

[System.Serializable]
public class BaseAbility : IAbility
{
    private AbilityBehavior abilityBehavior = default;
    private AbilityInformation abilityInfo = default;
    private TargetingType targetingType = default;
    public AbilityInformation AbilityInformation { get => abilityInfo; private set => abilityInfo = value; }
    public AbilityBehavior AbilityBehavior { get => abilityBehavior; set => abilityBehavior = value; }
    public TargetingType TargetingType { get => targetingType; }

    public BaseAbility(AbilityInformation abilityInfo)
    {
        AbilityInformation = abilityInfo;
    }

    public void Execute()
    {
        AbilityBehavior = abilityInfo.GeneralAbilityInfo.AbilityBehavior;
        AbilityBehavior.Execute();
        Debug.Log(AbilityInformation.AbilityName + " is Executing" + AbilityBehavior.name);
    }
}
