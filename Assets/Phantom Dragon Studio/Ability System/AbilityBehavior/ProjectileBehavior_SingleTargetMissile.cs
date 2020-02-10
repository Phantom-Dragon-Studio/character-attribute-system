using UnityEngine;

namespace PhantomDragonStudio.Ability_System
{
    [CreateAssetMenu(fileName ="New Ability Behavior", menuName ="Phantom Dragon Studio/Ability System/Single Target Behavior")]

    public class ProjectileBehavior_SingleTargetMissile : ProjectileBehavior, IProjectileBehavior
    {
        [SerializeField] private bool affectedByGravity = false;
        public bool AffectedByGravity { get => affectedByGravity; set => affectedByGravity = value; }
        public void Construct()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Constructing");
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public override void Dispose()
        {
            Debug.Log("AbilityBehavior_SingleTargetMissile: Dispose");
        }

        public void Execute(ProjectileData data)
        {
           Debug.Log("AbilityBehavior_SingleTargetMissile: Executing");
           //TODO Pull projectile from pool and assign it the correct values via Initialize().
           //
        }
    }
}
