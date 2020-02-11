using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;


namespace PhantomDragonStudio.CombatMechanics
{
    [CreateAssetMenu(fileName = "New Projectile Pool", menuName = "Phantom Dragon Studio/Pooling/Projectile Pool")]
    [Serializable]
    public class ProjectilePool : GenericPool<IProjectile>, IPool
    {
        [SerializeField] private Projectile projectilesToPool = default;
        [SerializeField] [ShowOnly] private int currentSize = default;

        private new KeyValuePair<int, IProjectile> pointer = new KeyValuePair<int, IProjectile>();
        private new Dictionary<int, IProjectile> pool = new Dictionary<int, IProjectile>();
        public Dictionary<int, IProjectile> Pool => pool;
        public override void GeneratePool()
        {
            currentSize = 0;
            for (int j = 0; j < startCount; j++)
            {
                IProjectile newProjectile = FactoryRequest();
                AddToPool(newProjectile);
            }
        }

        public void AddToPool<T>(T projectile)
        {
            if (Pool.ContainsKey(projectile.GetHashCode()))
            {
                Debug.LogError("Attempting to add an already existing character to " + this.name); 
                return;
            }
            pool.Add(projectile.GetHashCode(), projectile as IProjectile);
            currentSize = Pool.Count;
        }

        public IProjectile RemoveFromPool()
        {
            if (pool.Count > 0)
            {
                pointer = pool.First();
                pool.Remove(pointer.Key);
                currentSize = Pool.Count;
                return pointer.Value;
            }
            else
                Debug.LogError(this.name + " is trying to pull an object out of an empty pool.");

            FactoryRequest();
            return null;
        }

        protected override IProjectile FactoryRequest()
        {
            return ProjectileFactory.Create(projectilesToPool);
        }
    }
}
