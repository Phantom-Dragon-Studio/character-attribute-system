﻿using UnityEngine;

public interface ICharacterSheet
{
    ICharacterAttribute[] Attributes { get; }
    GeneralObjectInformation GeneralObjectInformation { get; }
    void OnEnable();
}
