using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public class Health : IHealth
    {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        public ICharacteristicController CharacteristicController { get; }
        public IHealthbar Healthbar { get; }

        public Health(ICharacteristicController controllerToWatch)
        {
            Healthbar = new Healthbar(this);
            CharacteristicController = controllerToWatch;
            controllerToWatch.CombatStats.MaxHealth.Calculated += (sender, args) => GetMaxHealth(args.Stat); //TODO Unsubscribe from onHealedEvent
            controllerToWatch.Character.Healed += (sender, args) => ApplyCurrentHealthIncrease(args.Amount); //TODO Unsubscribe from onHealedEvent
        }

        private void GetMaxHealth(ICombatStat stat)
        {
            Debug.Log(this.CharacteristicController.Character.GeneralObjectInformation.Name + " " + stat);
            Debug.Log(stat.PrimaryAttributeCalculatedValue);

            MaxHealth = stat.PrimaryAttributeCalculatedValue + stat.SecondaryAttributeCalculatedValue;
        }

        private void ApplyCurrentHealthIncrease(float amount)
        {
            //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
            Debug.Log("Healed EVENT: Increasing " + CharacteristicController.Character.GeneralObjectInformation.Name + "'s health by " + amount.ToString());
            CurrentHealth += amount;

            if (CurrentHealth > MaxHealth) 
                CurrentHealth = MaxHealth;
        }
    }
}