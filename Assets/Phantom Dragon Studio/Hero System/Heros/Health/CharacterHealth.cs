using System;
using System.Collections;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class CharacterHealth : Health, IDisposable
    {
        private Character character;
        public CharacterHealth(Character characterToMonitor)
        {
            character = characterToMonitor;
            
            character.CharacteristicController.CombatStats.MaxHealth.Calculated += (sender, args) =>
            {
                if (!IsInitialized)
                    Initialize(args.Stat.Value);

                IncreaseMaxHealth(args.Stat.Value);
            };
            
            character.Healed += (sender, args) => UpdateCurrentHealth(args.Amount);
            character.Damaged += (sender, args) => UpdateCurrentHealth(-args.Amount);
        }

        public void Dispose()
        {   //TODO Not sure if we're unsubscribing correctly here. 
            character.Healed -= (sender, args) => { }; 
            character.Damaged -= (sender, args) => { }; 
        }

        protected override void HealthCheck()
        {
            base.HealthCheck();
            Debug.Log("Check");
            if(CurrentHealth == 0)
            {
                Debug.Log("Dead");
                character.Die();
            }
        }
    }
}