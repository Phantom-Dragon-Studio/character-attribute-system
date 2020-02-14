using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Fireball Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Fireball Ability", order = 1)]
    public class Fireball_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        [SerializeField] private ProjectilePool projectilePool;
        public StatusEffect[] StatusEffects => statusEffects;
        

        public override void Cast()
        {    //TODO We had issues with null references after everything appeared to be working...
             //Changed how we access the pool so it's more direct. It seems to be working.
            // Debug.Log(projectilePool);
            Debug.Log(AbilityInformation.GeneraInformation.Name + " is executing CAST OVERRIDE!");
            
            var casterTransform = Caster.transform;
            base.Cast();
            projectilePool.RemoveFromPool(casterTransform.position, casterTransform.rotation).Activate();
        }
    }
}
