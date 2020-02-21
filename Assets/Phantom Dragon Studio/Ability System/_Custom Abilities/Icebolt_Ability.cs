using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Icebolt Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Icebolt Ability", order = 1)]
    public class Icebolt_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        [SerializeField] private ProjectilePool projectilePool = default;
        public StatusEffect[] StatusEffects => statusEffects;
        

        public override void Cast()
        {  
            // Debug.Log(AbilityInformation.GeneraInformation.Name + " is casting!");
            var casterTransform = Caster.transform;
            base.Cast();
            projectilePool.RemoveFromPool(casterTransform.position, casterTransform.rotation).Activate();
        }
    }
}
