﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardStat : BaseStat, ICombatStat
{
    public event EventHandler<CombatStatCalculatedEventArgs> Calculated;
    protected override CharacterLeagueType LeagueType => CharacterLeagueType.Wizard;

    public WizardStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute) 
        : base(type, primaryAttribute, secondaryAttribute)
    {
    }

    protected override void Calculate()
    {
        base.Calculate();
        Value *= CombatManager.Instance.LeagueSettings[LeagueType].Settings[CombatStatType];
        Calculated?.Invoke((this), new CombatStatCalculatedEventArgs(Value));
    }
} 