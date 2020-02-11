using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public class BaseAbility : IAbility
    {
        public Ability AbilityInformation { get; }
        public AbilityController AbilityController { get; }
        protected BaseAbility(Ability abilityInfo, AbilityController abilityController)
        {
            AbilityInformation = abilityInfo;
            AbilityController = abilityController;
        }

        public void Cast()
        {
            Debug.Log(AbilityInformation.AbilityName + " is Casting (WIP)");
        }

        public void IncreaseLevel(int levelsToIncrease)
        {   
            AbilityInformation.GeneralAbilityInfo.AdjustLevel(levelsToIncrease);
        }

        public void DecreaseLevel(int levelsToDecrease)
        {   
            AbilityInformation.GeneralAbilityInfo.AdjustLevel(-levelsToDecrease);
        }
        
        public void EngageCooldown()
        {
            AbilityInformation.GeneralAbilityInfo.EngageCooldown();
        }

        public void ResetCooldown()
        {
            AbilityInformation.GeneralAbilityInfo.ResetCooldown();
        }
    }
}
