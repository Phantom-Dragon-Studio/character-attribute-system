
namespace PhantomDragonStudio.CombatMechanics
{
    public class Health
    {
        public float CurrentHealth { get; protected set; }
        public float MaxHealth { get; protected set; }
        
        protected bool IsInitialized = false;
        private float healthRatio;
        
        protected void Initialize(float amount)
        {
            MaxHealth = amount;
            CurrentHealth = MaxHealth;
            IsInitialized = true;
        }

        protected void UpdateCurrentHealth(float amount)
        {
            //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
            //TODO ~ Add BonusDamageReceived & DamageDecreased logic here.
            CurrentHealth += amount;
            HealthCheck();
        }

        protected void IncreaseMaxHealth(float amountToIncrease)
        {
            GetCurrentHealthRatio();
            MaxHealth += amountToIncrease;
            CurrentHealth = MaxHealth * healthRatio;
            HealthCheck();
        }
        
        private void GetCurrentHealthRatio()
        {
            healthRatio = CurrentHealth / MaxHealth;
        }
        
        private void HealthCheck()
        {
            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
            else if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }
    }
}
