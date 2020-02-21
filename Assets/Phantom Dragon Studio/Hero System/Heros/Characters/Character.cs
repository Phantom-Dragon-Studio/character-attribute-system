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
            Damaged?.Invoke(this, new DamagedEventArgs(amount));
        }

        public void RestoreHealth(float amount)
        {
            //Debug.Log("Attempting to heal...");
            Healed?.Invoke(this, new HealedEventArgs(amount));
        }

        public void Die()
        {
            //TODO Stuff that happens when you die.
            //Return To Pool
            Destroy(this.gameObject);
        }
    }
}