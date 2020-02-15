using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class ProjectilePoolHandler : MonoBehaviour
    {
        [SerializeField] private ProjectilePool pool = default;
        [SerializeField] public Projectile_Character_InteractionHandler interactionsHandler = default;
        public Projectile_Character_InteractionHandler InteractionsHandler => interactionsHandler;
        public ProjectilePool Pool => pool;

        private void Awake()
        {
            Debug.Log("Awake");
            Pool.GeneratePool(this);
        }
    }
}