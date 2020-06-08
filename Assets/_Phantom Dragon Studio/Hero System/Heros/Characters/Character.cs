﻿using System;
using UnityEngine;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.Environment;
using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    /// This class is the class for all alive units (Anything that can move basically because I intend on making structures their own script, similar to the Character script).
    /// </summary>
    [SelectionBase]
    [System.Serializable]
    public class Character : MonoBehaviour, ICharacter, IHealthMechanics
    {
        [SerializeField] private CharacterSheet characterSheet = default;
        public ICharacterSheet CharacterSheet => characterSheet;
        
        private CharacterHealth health;
        public CharacterHealth Health => health;
        public ICharacteristicController CharacteristicController { get; private set; }
        public bool IsActive { get; set; }
        public event EventHandler<HealedEventArgs> Healed;
        public event EventHandler<DamagedEventArgs> Damaged;
        private GameObject gameobject;
        public GameObject GameObject => gameobject;

        public ICharacter Construct(ICharacteristicController characteristicController)
        { 
            CharacteristicController = characteristicController;
            health = new CharacterHealth(this);
            gameobject = this.gameObject;
            CharacteristicController.Attributes.UpdateAttribute(AttributeType.Agility, 1);
            CharacteristicController.Attributes.UpdateAttribute(AttributeType.Strength, 1);
            CharacteristicController.Attributes.UpdateAttribute(AttributeType.Wisdom, 1);
            CharacteristicController.Attributes.UpdateAttribute(AttributeType.Endurance, 1);
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

        public void Die()
        {
            //TODO Play animation, wait, then deactivate and return to pool instead of destroying.
            //In order to return this to a pool, we'll probably have to use an event and have the character pool manager listen for this event.
            Destroy(this.gameObject);
        }

        public void Activate()
        {
            this.gameObject.SetActive(true);
        }

        public void Deactivate()
        {
            this.gameObject.SetActive(false);
        }
    }
}