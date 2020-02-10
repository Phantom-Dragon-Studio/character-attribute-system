using System;
using UnityEngine;
using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    /// <summary>
    /// This class is the class for all alive units (Anyting that can move basically because I intend on making structures their own script, similar to the Character script).
    /// </summary>
    [System.Serializable]
    [RequireComponent(typeof(Rigidbody))]
    public class Character : MonoBehaviour, ICharacter, ITargetable
    {
        [SerializeField] private CharacterSheet characterSheet = default;
        [SerializeField] private new Rigidbody rigidbody = default;
        public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;
        public ICharacterSheet CharacterSheet => characterSheet;
        public ICharacteristicController CharacteristicController { get; private set; }
        public IHealth Health { get; private set;  }

        public Rigidbody Rigidbody  => rigidbody;
        public Vector3 GetPosition => transform.position;
        public GameObject GetGameObject => this.gameObject;

        public event EventHandler<HealedEventArgs> Healed;
        public event EventHandler<DamagedEventArgs> Damaged;

        public ICharacter Construct(CharacteristicController characteristicController, Health health)
        {
            CharacteristicController = characteristicController;
            Health = health;
            return this;
        }

        public void Damage(float amount)
        {
            //Debug.Log("Attempting to heal...");
            Damaged?.Invoke(this, new DamagedEventArgs(amount));
        }

        public void Heal(float amount)
        {
            //Debug.Log("Attempting to heal...");
            Healed?.Invoke(this, new HealedEventArgs(amount));
        }

        public Vector3 GetVelocity()
        {
            return Rigidbody.velocity;
        }

        public class HealedEventArgs : EventArgs
        {
            public float Amount { get; private set; }
            public HealedEventArgs(float amount)
            {
                //Debug.Log("Healed Event Fired....");
                Amount = amount;
            }
        }

        public class DamagedEventArgs : EventArgs
        {
            public float Amount { get; private set; }
            public DamagedEventArgs(float amount)
            {
                //Debug.Log("Damaged Event Fired....");
                Amount = amount;
            }
        }
    }
}