using System;
using System.Collections.Generic;
using System.Linq;
using PhantomDragonStudio.PoolingSystem;
using PhantomDragonStudio.Tools;
using UnityEngine;

//TODO Verify all ID#s being used to store objects in the pool are all being pulled from the same component
//NOTE: GetHashCode is not collision-proof. Not all Hashcodes are unique. InstanceID's are unique but are attached to individual components.
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
                IProjectile freshInstance = FactoryRequest();
                AddToPool(freshInstance);
                freshInstance.Deactivate();
            }
        }

        public void AddToPool(IProjectile projectile)
        {
            if (!Pool.ContainsKey(projectile.Transform.GetInstanceID()))
            {
                pool.Add(projectile.Transform.GetInstanceID(), projectile);
                currentSize = Pool.Count;
            }else
                Debug.LogWarning("Attempting to add an already existing object to " + this + " with ID#: " + projectile.Transform.GetInstanceID());
        }


        public IProjectile RemoveFromPool(Vector3 _position, Quaternion _rotation)
        {
            position = _position;
            rotation = _rotation;
            if (pool.Count > 0)
            {
                pointer = pool.First();
                pool.Remove(pointer.Key);
                Debug.Log("Removed from pool: " + pointer.Value.Transform.GetInstanceID());
                currentSize = Pool.Count;
                pointer.Value.Transform.position = position;
                pointer.Value.Transform.rotation = rotation;
                return pointer.Value;
            }
            else
                Debug.LogWarning(this + " is trying to pull an object out of an empty pool.");
            freshInstance = FactoryRequest();
            Debug.Log("Created FOR pool: " + freshInstance.Transform.GetInstanceID());
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
