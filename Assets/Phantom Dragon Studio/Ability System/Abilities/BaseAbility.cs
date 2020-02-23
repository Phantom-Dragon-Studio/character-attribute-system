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
            AbilityInformation = abilityInformation;
            //Call base in child class then do custom behavior.
        }

        public virtual void Cast()
        {
            //override me
        }

        public void IncreaseLevel(int levelsToIncrease)
        {
            AbilityInformation.CurrentLevel += levelsToIncrease;
            if (AbilityInformation.CurrentLevel > AbilityInformation.MaxLevel)
                AbilityInformation.CurrentLevel = AbilityInformation.MaxLevel;
        }

        public void DecreaseLevel(int levelsToDecrease)
        {   
            AbilityInformation.CurrentLevel -= levelsToDecrease;
            if (AbilityInformation.CurrentLevel <= 0)
                AbilityInformation.CurrentLevel = 0;
        }
        
        public void EngageCooldown()
        {
            Caster.StartCoroutine(cooldownCoroutine);
        }

        public void ResetCooldown()
        {
            Caster.StopCoroutine(cooldownCoroutine);
        }

        private IEnumerator CooldownTick()
        {
            Debug.Log("Empty Cooldown Coroutine Started!");
            yield return null;
        }
    }
}
