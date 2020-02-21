using System;
using UnityEngine;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    /// This class is the class for all alive units (Anything that can move basically because I intend on making structures their own script, similar to the Character script).
    /// </summary>
    [System.Serializable]
    public class Character : MonoBehaviour, ICharacter, IHealthMechanics, IPoolable
    {
        [SerializeField] private CharacterSheet characterSheet = default;
        public ICharacterSheet CharacterSheet => characterSheet;
        
        private CharacterHealth health;
        public CharacterHealth Health => health;
        public ICharacteristicController CharacteristicController { get; private set; }
        public event EventHandler<HealedEventArgs> Healed;
        public event EventHandler<DamagedEventArgs> Damaged;

        public ICharacter Construct(CharacteristicController characteristicController)
        { 
            CharacteristicController = characteristicController;
            health = new CharacterHealth(this);
            return this;
        }

        public void TakeDamage(float amount)
        {
            //TODO Add BonusDamageReceived & DamageDecreased logic here
            Damaged?.Invoke(this, new DamagedEventArgs(amount));
        }

        public void RestoreHealth(float amount)
        {    
            //TODO Add BonusHealingReceived & HealingReduced
            Healed?.Invoke(this, new HealedEventArgs(amount));
        }

        public void ReturnToPool()
        {
            //Fire off an event containing our IPoolable as an arg. The universal pool handler will know what to do with this.
        }

        public void Die()
        {
            //TODO Stuff that happens when you die.
            ReturnToPool();
            Destroy(this.gameObject);
        }
    }
}