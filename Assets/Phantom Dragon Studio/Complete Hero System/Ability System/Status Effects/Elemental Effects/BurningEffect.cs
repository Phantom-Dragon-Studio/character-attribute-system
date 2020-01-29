using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BurningEffect : StatusEffect
{
    [SerializeField] StatusEffectFunctionality effectInformation = default;
    public StatusEffectFunctionality EffectInformation => effectInformation;


}
