using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.CombatMechanics.Projectiles;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class Projectile_Character_InteractionHandler : MonoBehaviour
    {
        [SerializeField] private CharacterPoolHandler characterPoolHandler = default;
        private ITargetable target;

        public void AddToWatchedProjectiles(IProjectile projectile)
        {
            projectile.Collided += (sender, args) => FindReceiver(args.GOInstanceID, args.Value);
        }

        public void RemoveFromWatchedProjectiles(IProjectile projectile)
        {
            projectile.Collided -= (sender, args) => FindReceiver(args.GOInstanceID, args.Value);
        }

        private void FindReceiver(int argsGoInstanceId, float argsValue)
        {
            target = characterPoolHandler.SearchAllPools(argsGoInstanceId);
            target?.Damage(argsValue);
        }
    }
}