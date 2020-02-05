using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    
    [System.Serializable]
    public class ProjectileData
    {
        [SerializeField] private float damage;
        [SerializeField] private float lifetime;
        [SerializeField] private float speed;

        public float Speed { get => speed; private set => speed = value; }
        public float Lifetime { get => lifetime; private set => lifetime = value; }
        public float Damage { get => damage; private set => damage = value; }
    }
}
