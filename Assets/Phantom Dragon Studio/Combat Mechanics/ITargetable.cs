using UnityEngine;

namespace PhantomDragonStudio.CombatMechanics
{
    public interface ITargetable
    {
        Vector3 GetPosition { get; }
        GameObject GetGameObject { get; }
        void Damage(float amount);
        void Heal(float amount);
        Vector3 CurrentVelocity();
    }
}
