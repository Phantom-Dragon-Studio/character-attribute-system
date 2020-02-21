
using System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Health
    {
        public float CurrentHealth { get; private set; }
        public float MaxHealth { get; private set; }
        
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
            CurrentHealth += amount;
            HealthCheck();
        }

        protected void IncreaseMaxHealth(float newAmount)
        {
            GetCurrentHealthRatio();
            MaxHealth = newAmount;
            CurrentHealth = MaxHealth * healthRatio;
            HealthCheck();
        }
        
        private void GetCurrentHealthRatio()
        {
            healthRatio = CurrentHealth / MaxHealth;
        }
        
        //If less than or the same as 0 then we should set to 0 and return false.
        //Then inside of the override we call this base function and react accordingly.
        //If it ever returns false that means the object should trigger it's death function.
        protected virtual void HealthCheck()
        {
            if (CurrentHealth > MaxHealth)
                CurrentHealth = MaxHealth;
            else if (CurrentHealth <= 0)
            {
                CurrentHealth = 0;
            }
        }
    }
}
