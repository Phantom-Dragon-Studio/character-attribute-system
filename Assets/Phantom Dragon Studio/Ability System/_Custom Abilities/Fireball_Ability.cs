using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Fireball Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Fireball Ability", order = 1)]
    public class Fireball_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        [SerializeField] private ProjectilePool projectilePool = default;
        public StatusEffect[] StatusEffects => statusEffects;
        

        public override void Cast()
        {  
            // Debug.Log(AbilityInformation.GeneraInformation.Name + " is casting!");
            var casterTransform = Caster.transform;
            base.Cast();
            //TODO Fix and move direction calculations.
            projectilePool.RemoveFromPool(casterTransform.position + casterTransform.transform.forward, casterTransform.rotation).Activate();
        }
    }
}
