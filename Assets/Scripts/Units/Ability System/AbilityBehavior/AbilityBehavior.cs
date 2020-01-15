﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbilityBehavior : ScriptableObject
{
    AbilityInformation _abilityInformation;
    public AbilityInformation AbilityInformation { get => this._abilityInformation; set { this._abilityInformation = value; }  }

    public abstract void Construct();

    public abstract void Execute();

    public abstract void Dispose();
}