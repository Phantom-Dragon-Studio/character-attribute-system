using System.Collections;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [System.Serializable]
    public abstract class BaseAbility : ScriptableObject, IAbility
    {
        [SerializeField] protected AbilityInfo abilityInformation = default;
        public AbilityInfo AbilityInformation { get; private set; }
        public AbilityController Caster { get; private set; }
        private IEnumerator cooldownCoroutine;
        
        public virtual void Initialize(AbilityController abilityController)
        {
            cooldownCoroutine = CooldownTick();
            Caster = abilityController;
        }

        public virtual void Cast()
        {
            Debug.Log("Base Ability is Casting for: " + AbilityInformation.GeneraInformation.Name);
        }

        public virtual void IncreaseLevel(int levelsToIncrease)
        {
            AbilityInformation.CurrentLevel += levelsToIncrease;
            if (AbilityInformation.CurrentLevel > AbilityInformation.MaxLevel)
                AbilityInformation.CurrentLevel = AbilityInformation.MaxLevel;
        }

        public virtual void DecreaseLevel(int levelsToDecrease)
        {   
            AbilityInformation.CurrentLevel -= levelsToDecrease;
            if (AbilityInformation.CurrentLevel <= 0)
                AbilityInformation.CurrentLevel = 0;
        }
        
        public virtual void EngageCooldown()
        {
            Caster.StartCoroutine(cooldownCoroutine);
        }

        public virtual void ResetCooldown()
        {
            Caster.StopCoroutine(cooldownCoroutine);
        }

        private IEnumerator CooldownTick()
        {
            yield return null;
        }
    }
}
