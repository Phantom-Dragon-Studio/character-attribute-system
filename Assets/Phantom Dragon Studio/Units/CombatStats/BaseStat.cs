using System;

public abstract class BaseStat
{
    public float Value { get; protected set; }
    public CombatStatType CombatStatType { get; protected set; }
    protected ICharacterAttribute PrimaryAttribute { get; set; }
    protected ICharacterAttribute SecondaryAttribute { get; set; }
    protected const float DefaultValue = 0f;

    public BaseStat(CombatStatType type, ICharacterAttribute primaryAttribute, ICharacterAttribute secondaryAttribute)
    {
        Value = DefaultValue;
        CombatStatType = type;
        PrimaryAttribute = primaryAttribute;
        SecondaryAttribute = secondaryAttribute;

        if (PrimaryAttribute != null)
            PrimaryAttribute.Changed += (sender, args) => Calculate();
        if (secondaryAttribute != null)
            SecondaryAttribute.Changed += (sender, args) => Calculate();
    }

    public override string ToString()
    {
        return CombatStatType + ": " + Value;
    }

    protected virtual void Calculate()
    {
        var primaryPlaceHolder = -1f;
        var secondaryPlaceHolder = -1f;


        if (PrimaryAttribute != null)
        {
            primaryPlaceHolder = PrimaryAttribute.AttributeInfo.value;
            primaryPlaceHolder *= GameManager.Instance.Settings.primaryAttributeAffectModifier;
        }
        if (SecondaryAttribute != null)
        {
            secondaryPlaceHolder = SecondaryAttribute.AttributeInfo.value;
            secondaryPlaceHolder = GameManager.Instance.Settings.secondaryAttributeAffectModifier;
        }

        Value = primaryPlaceHolder + secondaryPlaceHolder;
    }
}

public class CombatStatCalculatedEventArgs : EventArgs
{
    public float Value { get; }

    public CombatStatCalculatedEventArgs(float value)
    {
        Value = value;
    }
}