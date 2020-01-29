using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ElementalEffect : IElementalEffect
{
    [SerializeField] private PhysicalStatusEffectType physicalEffect;
    [SerializeField] private ElementalEffectType elementalType;
    [SerializeField] private float amount;

    public PhysicalStatusEffectType PhysicalEffectType => throw new System.NotImplementedException();
    public ElementalEffectType ElementalType { get => elementalType; set => elementalType = value; }
    public float Amount { get => amount; set => amount = value; }

    public override string ToString()
    {
        return ElementalType.ToString() + ": " + Amount.ToString();
    }
}
