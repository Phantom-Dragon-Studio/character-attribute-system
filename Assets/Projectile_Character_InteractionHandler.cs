using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using PhantomDragonStudio.PoolingSystem;
using UnityEngine;
using UnityEngine.Serialization;

public class Projectile_Character_InteractionHandler : MonoBehaviour
{
    [SerializeField] private CharacterPoolHandler characterPoolHandler = default;
    private ICharacter target;
    public void AddToWatchedProjectiles(IProjectile projectile)
    {
        projectile.Collided += (sender, args) => FindReceiver(args.GOInstanceID, args.Value);
    }

    private void FindReceiver(int argsGoInstanceId, float argsValue)
    {
        target = characterPoolHandler.Pool.FindInPool(argsGoInstanceId);
        target?.Damage(argsValue);
    }
}
