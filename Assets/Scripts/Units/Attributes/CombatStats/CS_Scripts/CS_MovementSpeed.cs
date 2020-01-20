using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_MovementSpeed : ICombatStat
{
    private float value = 0.05f;
    public CombatStatType CombatStatType { get => CombatStatType.MovementSpeed; }
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
        return "Movement Speed: " + value;
    }
}
