using System;
using System.Collections;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class Health : IHealth
    {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public IHealthbar Healthbar { get; }
        public ICharacteristicController CharacteristicController { get; }

        private bool IsInitialized = false;
        private float healthRatio;

        public Health(ICharacteristicController controllerToWatch)
        {
            Healthbar = new Healthbar(this);
            CharacteristicController = controllerToWatch;

            controllerToWatch.CombatStats.MaxHealth.Calculated += (sender, args) =>
            {
                if (!IsInitialized)
                    Initialize();

                UpdateMaxHealth(args.Stat);
            };

            controllerToWatch.Character.Healed += (sender, args) => UpdateCurrentHealth(args.Amount); //TODO Unsubscribe from onHealedEvent
        }

        private void Initialize()
        {
            MaxHealth = CharacteristicController.CombatStats.MaxHealth.Value;
            CurrentHealth = MaxHealth;
            IsInitialized = true;
        }

        private void GetCurrentHealthRatio()
        {
            healthRatio = CurrentHealth / MaxHealth;
        }

        private void UpdateMaxHealth(ICombatStat maxHealthStat)
        {
            //Debug.Log(this.CharacteristicController.Character.GeneralObjectInformation.Name + " " + maxHealthStat);
            GetCurrentHealthRatio();
            MaxHealth = maxHealthStat.Value;
            CurrentHealth = MaxHealth * healthRatio;
            HealthCheck();
        }

        private void UpdateCurrentHealth(float amount)
        {
            //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
            Debug.Log("Healed EVENT: Increasing " + CharacteristicController.Character.GeneralObjectInformation.Name + "'s health by " + amount.ToString());
            CurrentHealth += amount;
            HealthCheck();
        }

        private void HealthCheck()
        {
            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
            else if (CurrentHealth < 0)
                CurrentHealth = 0;
        }
    }
}