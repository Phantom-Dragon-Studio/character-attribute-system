using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PhysicalDefense : ICombatStat
{
    private float value = 0.10f;
    public CombatStatType CombatStatType { get => CombatStatType.PhysicalDefense; }
    public float Value { get => value; }

    public void Calculate(Warrior warrior)
    {

    }

    public void Calculate(Rogue rogue)
    {

    }

    public void Calculate(Wizard wizard)
    {

    }

    public override string ToString()
    {
        return "Physical Defense: " + value;
    }
}
