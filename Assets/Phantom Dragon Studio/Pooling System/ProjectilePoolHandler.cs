using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class ProjectilePoolHandler : MonoBehaviour
    {
        [SerializeField] private ProjectilePool pool = default;
        public ProjectilePool Pool => pool;

        private void Awake()
        {
            Pool.GeneratePool();
        }
    }
}