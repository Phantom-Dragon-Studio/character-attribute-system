using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public class BaseAbility : IAbility
    {
        public AbilityInformation AbilityInformation { get; }
        public AbilityBehavior AbilityBehavior { get; }
        public TargetingType TargetingType { get; }

        public BaseAbility(AbilityInformation abilityInfo)
        {
            AbilityInformation = abilityInfo;
            AbilityBehavior = AbilityInformation.GeneralAbilityInfo.AbilityBehavior;
        }

        public void Execute()
        {
            AbilityBehavior.Execute();
            Debug.Log(AbilityInformation.AbilityName + " is Executing" + AbilityBehavior.name);
        }

        public void IncreaseLevel(int levelsToIncrease)
        {   //TODO Ability LVL Up
            throw new System.NotImplementedException();
        }
    }
}
