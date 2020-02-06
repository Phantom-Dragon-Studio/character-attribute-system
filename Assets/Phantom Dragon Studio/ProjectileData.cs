using UnityEngine;

namespace PhantomDragonStudio
{
    
    [System.Serializable]
    public class ProjectileData
    {
        [SerializeField] private float value;
        [SerializeField] private float lifetime;
        [SerializeField] private float speed;

        public float Speed { get => speed; private set => speed = value; }
        public float Lifetime { get => lifetime; private set => lifetime = value; }
        public float Value { get => value; private set => this.value = value; }
    }
}
