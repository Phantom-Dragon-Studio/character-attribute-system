using System;
using UnityEngine;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    /// This class is the class for all alive units (Anyting that can move basically because I intend on making structures their own script, similar to the Character script).
    /// </summary>
    [System.Serializable]
    public class Character : MonoBehaviour, ICharacter
    {
        //Inspector Editable Field
        [SerializeField] private CharacterSheet characterSheet = default;
        public ICharacterSheet CharacterSheet => characterSheet;
        public ICharacteristicController CharacteristicController { get; private set; }
        public IHealth Health { get; private set;  }
        [SerializeField] public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;
        public event EventHandler<HealedEventArgs> Healed;

        public ICharacter Construct(CharacteristicController characteristicController, Health health)
        {
            CharacteristicController = characteristicController;
            Health = health;
            return this;
        }

        public void Heal(float amount)
        {
            //Debug.Log("Attempting to heal...");
            Healed?.Invoke(this, new HealedEventArgs(amount));
        }

        public class HealedEventArgs : EventArgs
        {
            public HealedEventArgs(float amount)
            {
                //Debug.Log("Healed Event Fired....");
                Amount = amount;
            }

            public float Amount { get; private set; }
        }
    }
}