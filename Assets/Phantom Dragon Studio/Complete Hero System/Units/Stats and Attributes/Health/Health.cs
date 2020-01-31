using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class Health : IHealth
    {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public ICombatController CombatController { get; }
        public IHealthbar Healthbar { get; }

        public Health(ICombatController controllerToWatch)
        {
            Healthbar = new Healthbar(this);
            CombatController = controllerToWatch;
            controllerToWatch.CombatStats.MaxHealth.Calculated += (sender, args) => GetMaxHealth(args.Value); //TODO Unsubscribe from onHealedEvent
            controllerToWatch.Character.Healed += (sender, args) => ApplyCurrentHealthIncrease(args.Amount); //TODO Unsubscribe from onHealedEvent
        }

        private void GetMaxHealth(float maxHealthStatValue)
        {
            //Debug.Log("Getting Max Health of..." + maxHealthStatValue);
            MaxHealth = maxHealthStatValue;
        }

        private void ApplyCurrentHealthIncrease(float amount)
        {
            //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
            Debug.Log("Healed EVENT: Increasing " + CombatController.Character.GeneralObjectInformation.Name + "'s health by " + amount.ToString());
            CurrentHealth += amount;

            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
            Debug.Log("Current: " + CurrentHealth);
            Debug.Log("Max: " + MaxHealth);
        }
    }
}