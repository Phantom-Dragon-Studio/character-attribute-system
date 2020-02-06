using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio
{
    public class Projectile : MonoBehaviour
    {
        private float speed;
        private new Rigidbody rigidbody;
        private ProjectileData projectileData;

        void Awake()
        {
            Initialize(2.5f);
        }

        public void Initialize(float _speed)
        {
            speed = _speed;
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.AddForce(Vector3.forward * (speed * 1000));
        }
    }
}