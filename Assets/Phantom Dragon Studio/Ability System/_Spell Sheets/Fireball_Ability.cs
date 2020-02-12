using PhantomDragonStudio.HeroSystem;
using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Fireball Ability", menuName = "Phantom Dragon Studio/Ability System/Abilities/Fireball Ability", order = 1)]
    public class Fireball_Ability : BaseAbility
    {
        [SerializeField] private StatusEffect[] statusEffects = default;
        public StatusEffect[] StatusEffects => statusEffects;

        public override void Cast()
        {
            base.Cast();
            Debug.Log(AbilityInformation.GeneraInformation.Name + " is executing CAST OVERRIDE!");
        }
    }
}
