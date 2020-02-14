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
    public class ProjectilePool : ScriptableObject,  IPool<IProjectile>
    {
        [SerializeField] protected int startCount = default;
        [SerializeField] private Projectile projectilesToPool = default;
        private IProjectile freshInstance;
        [SerializeField] [ShowOnly] private int currentSize = default;
        private KeyValuePair<int, IProjectile> pointer;
        private Dictionary<int, IProjectile> pool = new Dictionary<int, IProjectile>();
        private Vector3 position;
        private Quaternion rotation;
        public Dictionary<int, IProjectile> Pool => pool;
        public void GeneratePool()
        {
            currentSize = 0;
            for (int j = 0; j < startCount; j++)
            {
                IProjectile newProjectile = FactoryRequest();
                AddToPool(newProjectile);
                newProjectile.Deactivate();
            }
        }

        public void AddToPool(IProjectile projectile)
        {
            if (!Pool.ContainsKey(projectile.GetHashCode()))
            {
                pool.Add(projectile.GetHashCode(), projectile);
                currentSize = Pool.Count;
            }else
                Debug.LogWarning("Attempting to add an already existing character to " + this);
        }


        public IProjectile RemoveFromPool(Vector3 _position, Quaternion _rotation)
        {
            position = _position;
            rotation = _rotation;
            if (pool.Count > 0)
            {
                pointer = pool.First();
                pool.Remove(pointer.Key);
                Debug.Log("Removed from pool: " + pointer.Value.GetHashCode().ToString());
                currentSize = Pool.Count;
                pointer.Value.Transform.position = position;
                pointer.Value.Transform.rotation = rotation;
                return pointer.Value;
            }
            else
                Debug.LogWarning(this + " is trying to pull an object out of an empty pool.");
            FactoryRequest();
            Debug.Log("Created FOR pool: " + freshInstance.GetHashCode().ToString());
            Debug.Log(freshInstance.Transform);
            freshInstance.Transform.position = position;
            freshInstance.Transform.rotation = rotation;
            return freshInstance;
        }

        protected IProjectile FactoryRequest()
        {
            Debug.Log("Factory Request: Projectile");
            freshInstance = ProjectileFactory.Create(projectilesToPool, this);
            return freshInstance;
        }
    }
}
