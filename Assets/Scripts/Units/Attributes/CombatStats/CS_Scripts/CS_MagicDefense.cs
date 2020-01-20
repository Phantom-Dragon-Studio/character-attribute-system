using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_MagicDefense : ICombatStat
{
    private float value = 0.05f;
    public CombatStatType CombatStatType { get => CombatStatType.MagicDefense; }
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
        return "Critical Strike Chance: " + value * 100 + "%";
    }
}
