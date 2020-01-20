using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalResistance : IElementalResistance
{
    private ElementalEffectType elementalType;
    private float amount;

    public ElementalEffectType ElementalType { get => elementalType; set => elementalType = value; }
    public float Amount { get => amount; set => amount = value; }

    public override string ToString()
    {
        return "";
    }
}
