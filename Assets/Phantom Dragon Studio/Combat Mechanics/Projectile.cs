using System;
using UnityEngine;


//TODO We need to resolve swappable behavior file types in here. It may require inheritance... 
namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        [SerializeField] private Transform transform;
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
            projectileData = _projectileData;
            Behavior.Construct(this);
            hasCollided = false;
            owningPool = poolToUse;
        }

        public void Activate()
        {
            hasCollided = false;
            currentLifeTime = 0f;
            gameObject.SetActive(true);
            if (!hasCollided && Data.Lifetime > currentLifeTime);
            {
                Debug.Log("Behavior Should Perform = True #" + GetHashCode());
                behavior.Perform(this);
            }
        }

        public void Deactivate()
        {
            hasCollided = true;
            this.gameObject.SetActive(false);
            Pool.AddToPool(this);
            Debug.Log(this.GetHashCode() + " has deactivated.");
        }
        
        private void Update()
        { //TODO FIGURE OUT WHY BEHAVIOR'S AREN'T MOVING PROJECTILES
            currentLifeTime += Time.deltaTime;
            // behavior.Perform();
        }
        
        private void OnCollisionEnter(Collision other)
        {
            Behavior.End();
        }

    }
} 