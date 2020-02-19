using PhantomDragonStudio.CombatMechanics;
using UnityEngine;
using UnityEngine.Serialization;

namespace PhantomDragonStudio.PoolingSystem
{
    public class ProjectilePoolHandler : MonoBehaviour
    {
        [FormerlySerializedAs("pool")] [SerializeField] private ProjectilePool[] pools = default;
        [SerializeField] public Projectile_Character_InteractionHandler interactionsHandler = default;
        public Projectile_Character_InteractionHandler InteractionsHandler => interactionsHandler;
        public ProjectilePool[] Pools => pools;

        private void Awake()
        {
            for (int i = 0; i < pools.Length; i++)
            {
                pools[i].GeneratePool(this);
            }
        }
    }
}