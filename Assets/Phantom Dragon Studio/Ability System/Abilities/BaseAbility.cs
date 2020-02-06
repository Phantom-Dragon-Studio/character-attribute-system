using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public class BaseAbility : IAbility
    {
        public Ability AbilityInformation { get; }
        public IAbilityBehavior AbilityBehavior { get; }
        private ITargetable Target;

        public BaseAbility(Ability abilityInfo)
        {
            AbilityInformation = abilityInfo;
            AbilityBehavior = AbilityInformation.GeneralAbilityInfo.AbilityBehavior;
        }

        public void Cast()
        {
            Debug.Log(AbilityInformation.AbilityName + " is Casting with behavior: " + AbilityBehavior);
            AbilityBehavior.Execute();
        }

        public void IncreaseLevel(int levelsToIncrease)
        {   
            AbilityInformation.GeneralAbilityInfo.AdjustLevel(levelsToIncrease);
        }

        public void DecreaseLevel(int levelsToDecrease)
        {   
            AbilityInformation.GeneralAbilityInfo.AdjustLevel(-levelsToDecrease);
        }
    }
}
