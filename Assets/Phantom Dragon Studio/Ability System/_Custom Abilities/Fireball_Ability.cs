using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Fireball Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Fireball Ability", order = 1)]
    public class Fireball_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        [SerializeField] private Projectile projectile;
        public StatusEffect[] StatusEffects => statusEffects;
        

        public override void Cast()
        {
            base.Cast();
            projectile.Pool.RemoveFromPool();
            Debug.Log(AbilityInformation.GeneraInformation.Name + " is executing CAST OVERRIDE!");
        }
    }
}
