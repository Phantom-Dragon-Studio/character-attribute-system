using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;


namespace PhantomDragonStudio.CombatMechanics
{
    /// <summary>
    /// This pool is tracked by IProjectile InstanceID
    /// </summary>
    [CreateAssetMenu(fileName = "New Projectile Pool", menuName = "Phantom Dragon Studio/Pooling/Projectile Pool")]
    [Serializable]
    public class ProjectilePool : ScriptableObject,  IPool<IProjectile>
    {
        [SerializeField] protected int startCount = default;
        [SerializeField] private Projectile projectilesToPool = default;
        [SerializeField] [ShowOnly] private int currentSize = default;
        private IProjectile freshInstance;
        private KeyValuePair<int, IProjectile> pointer;
        private Dictionary<int, IProjectile> pool = new Dictionary<int, IProjectile>();
        private Vector3 position;
        private Quaternion rotation;

        public void GeneratePool(ProjectilePoolHandler projectilePoolHandler)
        {
            currentSize = 0;
            for (int j = 0; j < startCount; j++)
            {
                freshInstance = FactoryRequest();
                projectilePoolHandler.InteractionsHandler.AddToWatchedProjectiles(freshInstance);
                freshInstance.Deactivate();
            }
        }
        
        public IProjectile FindInPool(int key)
        {
            return pool.ContainsKey(key) ? pool[key] : null;
        }

        public void AddToPool(IProjectile target)
        {
            if (!pool.ContainsKey(target.GetInstanceID()))
            {
                pool.Add(target.GetInstanceID(), target);
                currentSize = pool.Count;
            }
            else
                Debug.LogWarning("Attempting to add an already existing object to " + this + " with ID: " + target.GetInstanceID().ToString());
        }


        public IProjectile RemoveFromPool(Vector3 _position, Quaternion _rotation)
        {
            position = _position;
            rotation = _rotation;
            if (pool.Count > 0)
            {
                pointer = pool.FirstOrDefault();
                pool.Remove(pointer.Key);
                currentSize = pool.Count;
                pointer.Value.Transform.position = position;
                pointer.Value.Transform.rotation = rotation;
                
                // Debug.Log("Removed from pool: " + pointer.Value.Transform.GetInstanceID());
                return pointer.Value;
            }
            freshInstance = FactoryRequest();
            freshInstance.Transform.position = position;
            freshInstance.Transform.rotation = rotation;

            Debug.LogWarning("Created NEW: " + freshInstance + " with InstanceID: " + freshInstance.Transform.GetInstanceID().ToString() + " for pool: " + this);
            return freshInstance;
        }

        protected IProjectile FactoryRequest()
        {
            freshInstance = ProjectileFactory.Create(projectilesToPool, this);
            return freshInstance;
        }
    }
}
