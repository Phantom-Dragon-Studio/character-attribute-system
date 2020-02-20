using System;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [Serializable]
    public class DestructibleHealth
    {
        [SerializeField] private float maxHealth = default;
        private float currentHealth;
        private float healthRatio;
        private Destructible destructible;

        public void Initialize(Destructible _destructible)
        {
            destructible = _destructible;
            currentHealth = maxHealth;
        }

        private void GetCurrentHealthRatio()
        {
            healthRatio = currentHealth / maxHealth;
        }

        public void UpdateMaxHealth()
        {
            GetCurrentHealthRatio();
            currentHealth = maxHealth * healthRatio;
            HealthCheck();
        }

        public void UpdateCurrentHealth(float amount)
        {
            currentHealth += amount;
            HealthCheck();
        }

        private void HealthCheck()
        {
            if (currentHealth > maxHealth)
                currentHealth = maxHealth;
            else if (currentHealth < 0)
            {
                currentHealth = 0;
                //TODO Death stuff
                destructible.Dispose();
            }
        }
    }
}