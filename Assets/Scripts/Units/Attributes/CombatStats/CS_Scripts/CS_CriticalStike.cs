using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_CriticalStike : ICombatStat
{
    private float value = 0.05f;
    public CombatStatType CombatStatType { get => CombatStatType.CriticalStrikeChance; }
    public float Value { get => value; }

    public override string ToString()
    {
        return "Critical Strike Chance: " + value * 100 + "%";
    }
}
