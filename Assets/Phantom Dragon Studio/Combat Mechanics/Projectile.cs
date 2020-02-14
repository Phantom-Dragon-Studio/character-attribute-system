using System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        [SerializeField] private new Transform transform;
        [SerializeField] private ProjectileData projectileData = default;
        [SerializeField] private SingleTargetMissile behavior;
        [SerializeField] private new Rigidbody rigidbody;
        public ProjectilePool Pool => owningPool;
        public ProjectileData Data => projectileData;
        public Transform Transform => transform;
        public SingleTargetMissile Behavior => behavior;
        public Rigidbody Rigidbody => rigidbody;
        private float currentLifeTime;
        private ProjectilePool owningPool;
        private Boolean hasCollided = true;
        public Boolean Collided => hasCollided;
        public void Initialize(ProjectileData _projectileData, SingleTargetMissile _behavior, ProjectilePool poolToUse)
        {
            transform = gameObject.transform;
            projectileData = _projectileData;
            hasCollided = false;
            owningPool = poolToUse;
            Behavior.Construct(this);
        }

        public void Activate()
        {
            hasCollided = false;
            currentLifeTime = 0f;
            gameObject.SetActive(true);
            if (!hasCollided && Data.Lifetime > currentLifeTime);
            {
                Debug.Log("Behavior Should Perform = True #" + transform.GetInstanceID());
                behavior.Perform(this);
            }
        }

        public void Deactivate()
        {
            hasCollided = true;
            this.gameObject.SetActive(false);
            Pool.AddToPool(this);
            Debug.Log(transform.GetInstanceID() + " has deactivated.");
        }
        
        private void Update()
        {
            currentLifeTime += Time.deltaTime;
        }
        
        private void OnCollisionEnter(Collision other)
        {
            Debug.Log(transform.GetInstanceID() + " has collided with " + other.gameObject.name);
            Behavior.End(this);
        }

    }
} 