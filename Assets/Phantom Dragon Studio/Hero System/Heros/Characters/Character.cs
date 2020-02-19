using System;
using UnityEngine;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.Tools;

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
        private new Transform transform;
        public GeneralObjectInformation GeneralObjectInformation => characterSheet.GeneralObjectInformation;
        public ICharacterSheet CharacterSheet => characterSheet;
        public ICharacteristicController CharacteristicController { get; private set; }
        public IHealth Health { get; private set;  }

        public Transform Transform => transform;
        public Rigidbody Rigidbody  => rigidbody;
        public Vector3 GetPosition => transform.position;
        public GameObject GetGameObject => this.gameObject;
        public event EventHandler<HealedEventArgs> Healed;
        public event EventHandler<DamagedEventArgs> Damaged;

        public ICharacter Construct(CharacteristicController characteristicController, Health health)
        {
            transform = gameObject.transform;
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

        public Vector3 CurrentVelocity()
        {
            return Rigidbody.velocity;
        }

        public void Die()
        {
            //TODO Stuff that happens when you die.
            Destroy(this.gameObject);
        }
    }
}