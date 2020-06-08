﻿using UnityEngine;
using PhantomDragonStudio.CombatMechanics.Projectiles;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine.InputSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public class ProjectileSpawner : MonoBehaviour
    {
        [SerializeField] private ProjectilePool [] pools = default;
        private IProjectile spawnedProjectile;
        private Transform attachmentPointTransform;

        private void Awake()
        {
            attachmentPointTransform = transform;
        }

        public void LaunchPrimaryProjectile(InputAction.CallbackContext context)
        {
            if (!context.performed) return;
            spawnedProjectile = pools[0].RemoveFromPool();
            spawnedProjectile.Transform.position = attachmentPointTransform.position;
            spawnedProjectile.Transform.rotation = attachmentPointTransform.rotation;
            spawnedProjectile.Activate();
        }
        
        public void LaunchSecondaryProjectile(InputAction.CallbackContext context)
        {
            if (!context.performed) return;
            spawnedProjectile = pools[1].RemoveFromPool();
            spawnedProjectile.Transform.position = attachmentPointTransform.position;
            spawnedProjectile.Transform.rotation = attachmentPointTransform.parent.rotation;
            spawnedProjectile.Activate();
        }
    }
}