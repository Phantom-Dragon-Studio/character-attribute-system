using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public static class DamageablePoolHandler
    {
        private static IPool<IDamageable> pool = ScriptableObject.CreateInstance<DamageablePool>();
        private static IDamageable foundIndex;
        
        public static IDamageable SearchPool(int InstanceID)
        {
            foundIndex = null;
            foundIndex = pool.FindInPool(InstanceID);
                return foundIndex ?? null;
        }

        public static void AddToPool(IDamageable damageable)
        {
            // Debug.Log("Adding " + damageable.GameObject.ToString() + " to DamageablePool.");
            pool.AddToPool(damageable);
        }

        public static void RemoveFromPool(IDamageable damageable)
        {
            if (pool.FindInPool(damageable.GameObject.GetInstanceID()) != null)
            {
                pool.RemoveFromPool(damageable);
            }
        }
    }
}