using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.CombatMechanics;
using UnityEngine;

public class TemporaryFloatingDeck : MonoBehaviour, IFloatingDeck, ITargetable
{
    public Vector3 GetPosition { get; }
    public GameObject GetGameObject { get; }
    public void Damage(float amount)
    {
        throw new System.NotImplementedException();
    }

    public void Heal(float amount)
    {
        throw new System.NotImplementedException();
    }

    public Vector3 CurrentVelocity()
    {
        throw new System.NotImplementedException();
    }

    public void Activate()
    {
        throw new System.NotImplementedException();
    }

    public void Deactivate()
    {
        throw new System.NotImplementedException();
    }
}
