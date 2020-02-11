using System;
using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        private float speed;
        private new Rigidbody rigidbody;
        public ProjectileData Data { get; private set; }
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private SingleTargetMissile behavior;
        public SingleTargetMissile Behavior {  get => behavior; private set => behavior = value; }
        private Boolean hasCollided = true;
        public void Initialize(float _speed, SingleTargetMissile behavior)
        {
            this.behavior = behavior;
            Data = projectileData;
            speed = _speed;
            rigidbody = GetComponent<Rigidbody>();
            
            Behavior.Construct(Data);
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            if(hasCollided == false)
                rigidbody.AddForce(Vector3.forward * speed);
            //Add logic to stop, hide, and return to pool.
        }

        private void OnCollisionEnter(Collision other)
        {
            //Debug.Log(other.collider.gameObject.GetHashCode().ToString());
            //TODO Fire off onCollisionEvent with args of GetHashCode().
            hasCollided = true;
        }
    }
} 