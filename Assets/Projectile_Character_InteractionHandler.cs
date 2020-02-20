using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.PoolingSystem
{
    public class Projectile_Character_InteractionHandler : MonoBehaviour
    {
        [SerializeField] private CharacterPoolHandler characterPoolHandler = default;
        private ITargetable target;

        public void AddToWatchedProjectiles(ICollisionHandler collisionHandler)
        {
            collisionHandler.Collided += (sender, args) => FindReceiver(args.GOInstanceID, args.Value);
        }

        public void RemoveFromWatchedProjectiles(ICollisionHandler collisionHandler)
        {
            collisionHandler.Collided -= (sender, args) => FindReceiver(args.GOInstanceID, args.Value);
        }

        private void FindReceiver(int argsGoInstanceId, float argsValue)
        {
            target = characterPoolHandler.SearchAllPools(argsGoInstanceId);
            target?.Damage(argsValue);
        }
    }
}