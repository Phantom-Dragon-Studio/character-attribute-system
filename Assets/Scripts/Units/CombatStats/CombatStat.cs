using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStat : ICombatStat
{
    private const float DefaultAmount = 0.00f;

    public float Value { get; private set; }
    public event EventHandler<CombatStatCalculatedEventArgs> Calculated;
    public CombatStatType CombatStatType { get; }

    private ICharacterAttribute PrimaryAttribute { get; set; }
    private ICharacterAttribute SecondaryAttribute { get; set; }
    
    private const float DefaultValue = 0;

    public CombatStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute)
    {
        Value = DefaultValue;
        CombatStatType = type;
        PrimaryAttribute = primaryAttribute;
        SecondaryAttribute = secondaryAttribute;
        
        if(PrimaryAttribute != null)
            PrimaryAttribute.Changed += (sender, args) => Calculate();
        if(secondaryAttribute != null)
            SecondaryAttribute.Changed += (sender, args) => Calculate();
    }

    //TODO Add Game Manager CombatStat Modifier Reference to allow for unique calculations based upon type enum. 
    private void Calculate()
    {
        var primaryPlaceHolder = -1f; 
        var secondaryPlaceHolder = -1f;
        
        if(PrimaryAttribute != null)
            primaryPlaceHolder = PrimaryAttribute.AttributeInfo.value;
        if(SecondaryAttribute != null)
            secondaryPlaceHolder = SecondaryAttribute.AttributeInfo.value;
        
        Value = primaryPlaceHolder + secondaryPlaceHolder;
        Value += CombatManager.instance.RogueCombatStatModifiers(CombatStatType);
        Calculated?.Invoke((this), new CombatStatCalculatedEventArgs(Value));
    }

    public override string ToString()
    {
        return CombatStatType + ": " + Value;
    }
    
    public class CombatStatCalculatedEventArgs : EventArgs
    {
        public float Value { get; }
        
        public CombatStatCalculatedEventArgs(float value)
        {
            Value = value;
            //Debug.Log("Calculated CombatStat EVENT FIRED.");
        }
    }
}
