using System;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [Serializable]
    public class DestructibleHealth : Health
    {
        private Destructible destructible;

        public void Initialize(float amount, Destructible destructibleToWatch)
        {
            base.Initialize(amount);
            destructible = destructibleToWatch;
        }
        
        protected override void HealthCheck()
        {
            base.HealthCheck();
            if(CurrentHealth == 0)
                destructible.Dispose();
        }
    }
}