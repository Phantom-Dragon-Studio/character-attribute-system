using UnityEngine;
public interface ITargetable
{
    Vector3 GetPosition { get; }
    GameObject GetGameObject { get; }
    void Damage(float amount);
    void Heal(float amount);
}
