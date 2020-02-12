using System;
using UnityEngine;
using PhantomDragonStudio.PoolingSystem;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private SingleTargetMissile behavior;
        [SerializeField] private ProjectilePool owningPool;
        public ProjectilePool Pool { get => owningPool; private set => owningPool = value; }
        public ProjectileData Data { get => projectileData; private set => projectileData = value; }
        public SingleTargetMissile Behavior {  get => behavior; private set => behavior = value; }
        private new Rigidbody rigidbody;
        private Boolean hasCollided = true;
        public void Initialize(ProjectileData projectileData, SingleTargetMissile behavior)
        {
            this.behavior = behavior;
            Data = projectileData;
            rigidbody = GetComponent<Rigidbody>();
            Behavior.Construct(Data);
            hasCollided = true;
        }

        private void Update()
        {
            Behavior.Perform();
        }

        private void OnCollisionEnter(Collision other)
        {
            //Debug.Log(other.collider.gameObject.GetHashCode().ToString());
            //TODO Fire off onCollisionEvent with args of GetHashCode().
            hasCollided = true;
            Pool.AddToPool(this);
        }
    }
} 