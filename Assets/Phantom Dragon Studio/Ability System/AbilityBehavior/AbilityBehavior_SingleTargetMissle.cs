using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName ="New Ability Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class AbilityBehavior_SingleTargetMissle : AbilityBehavior
    {
        [SerializeField] ProjectileData projectileData = default;
        [SerializeField] private bool affectedByGravity = false;

        public ProjectileData ProjectileData { get => projectileData; set => projectileData = value; }
        public bool AffectedByGravity { get => affectedByGravity; set => affectedByGravity = value; }

        public override void Construct()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissle: Constructing"); 
        }

        public override void Dispose()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissle: Dispose");
        }

        public override void Execute()
        {
           Debug.Log("AbilityBehavior_SingleTargetMissle: Executing");
        }

    }
}
