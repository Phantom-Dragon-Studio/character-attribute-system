using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName ="New Ability Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class AbilityBehavior_SingleTargetMissile : AbilityBehavior
    {
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private bool affectedByGravity = false;
        public ProjectileData ProjectileData { get => projectileData; set => projectileData = value; }
        public bool AffectedByGravity { get => affectedByGravity; set => affectedByGravity = value; }
        public override IAbility Ability { get; set; }

        public override void Construct(IAbility ability)
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Constructing");
            Ability = ability;
        }

        public override void Dispose()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Dispose");
        }

        public override void Execute()
        {
           Debug.Log("AbilityBehavior_SingleTargetMissile: Executing");
           Debug.Log(Ability);
           Debug.Log(Ability.AbilityController.transform);
           
           ProjectileFactory.Create(
               Ability.AbilityInformation.GeneralAbilityInfo.Sfx, Ability.AbilityController.transform);
        }
    }
}
