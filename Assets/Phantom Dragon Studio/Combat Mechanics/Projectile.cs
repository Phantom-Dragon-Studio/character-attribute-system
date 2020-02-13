using System;
using UnityEngine;
using PhantomDragonStudio.PoolingSystem;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private SingleTargetMissile behavior;
        [SerializeField] private new Rigidbody rigidbody;
        public ProjectilePool Pool => owningPool;
        public ProjectileData Data => projectileData;
        public Transform Transform => transform;
        public SingleTargetMissile Behavior => behavior;
        public Rigidbody Rigidbody => rigidbody;

        private float currentLifeTime;
        private ProjectilePool owningPool;
        private new Transform transform;
        private Boolean hasCollided = true;
        public void Initialize(ProjectileData _projectileData, SingleTargetMissile _behavior, ProjectilePool poolToUse)
        {
            this.behavior = _behavior;
            projectileData = _projectileData;
            Behavior.Construct(this);
            hasCollided = false;
            owningPool = poolToUse;
            transform = this.transform;
            Debug.Log("Pool: " +  owningPool);
        }

        public void Activate()
        {
            this.gameObject.SetActive(true);
            Debug.Log(this.name + " has Activated.");
            currentLifeTime = 0f;
            //TODO Finish behavior loop.
            // while (!hasCollided && Data.Lifetime > currentLifeTime)
            // {
            //     Behavior.Perform();
            // }
            Debug.Log("While Loop ended. Current Lifetime: " + currentLifeTime + " Has Collided: " + hasCollided);
            owningPool.AddToPool(this);
        }

        public void Deactivate()
        {
            hasCollided = true;
            Behavior.End();
            this.gameObject.SetActive(false);
            Debug.Log(this.name + " has deactivated.");
        }
        
        private void Update()
        {
            currentLifeTime += Time.deltaTime;
        }
        
        private void OnCollisionEnter(Collision other)
        {
            Deactivate();
        }

    }
} 