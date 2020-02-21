using System;
using System.Collections;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class CharacterHealth : Health, IDisposable
    {
        private Character character;
        public CharacterHealth(Character character)
        {
            character.CharacteristicController.CombatStats.MaxHealth.Calculated += (sender, args) =>
            {
                if (!IsInitialized)
                    Initialize(args.Stat.Value);

                IncreaseMaxHealth(args.Stat.Value);
            };
            
            character.Healed += (sender, args) => UpdateCurrentHealth(args.Amount);
            character.Damaged += (sender, args) => UpdateCurrentHealth(-args.Amount); //TODO Unsubscribe from onHealedEvent
        }

        public void Dispose()
        {
            character.Healed -= (sender, args) => { }; 
            character.Damaged -= (sender, args) => { }; 
        }
    }
}