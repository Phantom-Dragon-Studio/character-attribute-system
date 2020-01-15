﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour, IHealthbar
{
    ICharacter characterToMonitor;

    public Healthbar(ICharacter character)
    {
        characterToMonitor = character;
    }
}
