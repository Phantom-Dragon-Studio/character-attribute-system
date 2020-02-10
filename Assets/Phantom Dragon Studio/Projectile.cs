using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Ability_System;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio
{
    public class Projectile : MonoBehaviour, IProjectile
    {
        private float speed;
        private new Rigidbody rigidbody;
        public ProjectileData Data { get; private set; }
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private ProjectileBehavior_SingleTargetMissile behavior;
        public ProjectileBehavior_SingleTargetMissile Behavior {  get => behavior; private set => behavior = value; }
        private Boolean hasCollided = true;
        public void Initialize(float _speed, ProjectileBehavior_SingleTargetMissile behavior)
        {
            this.behavior = behavior;
            Data = projectileData;
            speed = _speed;
            rigidbody = GetComponent<Rigidbody>();
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