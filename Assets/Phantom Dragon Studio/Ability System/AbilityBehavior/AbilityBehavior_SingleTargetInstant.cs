using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName = "New Instant Ability Behavior", menuName = "Phantom Dragon Studio/Ability System/Single Target Instant Behavior")]

    public class AbilityBehavior_SingleTargetInstant : AbilityBehavior
    {
        [SerializeField] ProjectileData projectileData = default;
        public ProjectileData ProjectileData { get => projectileData; set => projectileData = value; }

        public override void Construct()
        {
            Debug.Log("AbilityBehavior_SingleTargetInstant: Constructing");
        }

        public override void Dispose()
        {
            Debug.Log("AbilityBehavior_SingleTargetInstant: Dispose");
        }

        public override void Execute()
        {
            Debug.Log("AbilityBehavior_SingleTargetInstant: Executing");
            //
        }

    }
}
