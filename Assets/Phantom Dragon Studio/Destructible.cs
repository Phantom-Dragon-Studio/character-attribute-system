using System;
using System.Collections;
using System.Collections.Generic;
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

    private void OnCollisionEnter(Collision other)
    {
        //TODO Change this so it can be damaged multiple ways.
        Debug.Log("Tink");
        Damage(other.gameObject.GetComponent<Projectile>().Data.Value);
    }
}
