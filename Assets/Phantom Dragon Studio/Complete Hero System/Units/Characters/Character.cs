using System;
using UnityEngine;
using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Hero_System
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
        public ICombatController CombatController { get; private set; }
        public IHealth Health { get; private set;  }
        [SerializeField] public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;
        public event EventHandler<HealedEventArgs> Healed;

        public ICharacter Construct(CombatController combatController, Health health)
        {
            CombatController = combatController;
            Health = Health;
            return this;
        }

        public void Heal(float amount)
        {
            Debug.Log("Attempting to heal...");
            Healed?.Invoke(this, new HealedEventArgs(amount));
        }

        public class HealedEventArgs : EventArgs
        {
            public HealedEventArgs(float amount)
            {
                Debug.Log("Healed Event Fired....");
                Amount = amount;
            }

            public float Amount { get; private set; }
        }
    }
}