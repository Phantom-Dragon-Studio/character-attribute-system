using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "Projectile Data", menuName = "New Projectile Data", order = 0)]

    [System.Serializable]
    public class ProjectileData : ScriptableObject
    {
        [SerializeField] new string name;
        [SerializeField] Sprite icon;
        [SerializeField] GameObject sfx;
        [SerializeField] private ElementalEffect element;
        [SerializeField] private float damage;
        [SerializeField] private float lifetime;
        [SerializeField] private float speed;

        public float Speed { get => speed; private set => speed = value; }
        public float Lifetime { get => lifetime; private set => lifetime = value; }
        public float Damage { get => damage; private set => damage = value; }
        public ElementalEffect Element { get => element; private set => element = value; }
        public GameObject SFX { get => sfx; private set => sfx = value; }
        public Sprite Icon { get => icon; private set => icon = value; }
        public string Name { get => name; private set => name = value; }
    }
}
