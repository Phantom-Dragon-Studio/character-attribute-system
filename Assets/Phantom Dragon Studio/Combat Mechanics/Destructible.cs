using System;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

public class Destructible : MonoBehaviour, ITargetable, IDisposable
{
    public Rigidbody rb;
    [SerializeField] private DestructibleHealth destructibleHealth = default;
    public Vector3 GetPosition { get; }
    public GameObject GetGameObject { get; }
    public Transform Transform { get; }

    private void Awake()
    {
        destructibleHealth.Initialize(this);
    }

    public void Damage(float amount)
    {
        destructibleHealth.UpdateCurrentHealth(-amount);
    }

    public void Heal(float amount)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 CurrentVelocity()
    {
        return rb.velocity;
    }

    public void Dispose()
    {
        Destroy(this.gameObject);
    }
}
