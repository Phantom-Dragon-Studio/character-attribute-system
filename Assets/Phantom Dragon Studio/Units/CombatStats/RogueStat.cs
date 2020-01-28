using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueStat : BaseStat, ICombatStat
{
    public event EventHandler<CombatStatCalculatedEventArgs> Calculated;

    public RogueStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute) 
        : base(type, primaryAttribute, secondaryAttribute)
    {
    }

    protected override void Calculate()
    {
        base.Calculate();
        Value *= CombatManager.Instance.RogueCombatStatModifiers(CombatStatType);
        Calculated?.Invoke((this), new CombatStatCalculatedEventArgs(Value));
    }
} 