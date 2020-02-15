﻿using System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        [SerializeField] private new Transform transform = default;
        [SerializeField] private ProjectileData projectileData = default;
        [SerializeField] private ProjectileBehavior behavior = default;
        [SerializeField] private new Rigidbody rigidbody = default;

        public event EventHandler<ProjectileCollisionEventArgs> Collided = default;
        
        #region Private Variable
        private float currentLifeTime;
        private ProjectilePool owningPool;
        private Boolean hasHasCollided = true;
        private int collisions = 0;
        #endregion
        
        #region Getters

        public ProjectileData Data => projectileData;
        public Transform Transform => transform;
        public ProjectileBehavior Behavior => behavior;
        public Rigidbody Rigidbody => rigidbody;
        public Boolean HasCollided => hasHasCollided;

        #endregion
        
        public void Initialize(ProjectileData _projectileData, ProjectileBehavior _behavior, ProjectilePool poolToUse)
        {
            transform = gameObject.transform;
            projectileData = _projectileData;
            hasHasCollided = false;
            owningPool = poolToUse;
            //Behavior.Construct(this); Not necessary in this script. Other projectile variants may utilize it though.
        }

        public void Activate()
        {
            hasHasCollided = false;
            collisions = 0;
            currentLifeTime = 0f;
            gameObject.SetActive(true);
            if (!hasHasCollided && Data.Lifetime > currentLifeTime)
                behavior.Perform(this);
        }

        public void Deactivate()
        {
            this.gameObject.SetActive(false);
            if (collisions <= 1)
            {
                owningPool.AddToPool(this);
            }
            // Debug.Log(transform.GetInstanceID() + " has deactivated.");
        }
        
        private void Update()
        {
            currentLifeTime += Time.deltaTime;
        }
        
        private void OnCollisionEnter(Collision other)
        {
            collisions++;
            hasHasCollided = true;
            Behavior.End(this);
            if (collisions <= 1)
            {
                Collided?.Invoke(this, new ProjectileCollisionEventArgs(other.gameObject.transform.GetInstanceID(), projectileData.Value));
            }
        }
    }
} 