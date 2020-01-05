using UnityEngine;

/// <summary>
/// This class is strictly a data container containing a pair of values, but is more managable than using a key value pair.
/// </summary>
public enum AttributeType
{
    //Note: Any items added or removed in this Enum should also be updates to reflect inside the CharacterAttributes constructor.
    //TODO-- Finish adding all attribute getters.
    Agility,
    Strength,
    Wisdom,
    Endurance,
}

[System.Serializable]
public class Attribute
{
    public Attribute(AttributeType statType, float amount)
    {
        Amount = amount;
        AttributeType = statType;
    }

    [SerializeField] private AttributeType attributeType;
    [SerializeField] private float amount;

    public AttributeType AttributeType { get => attributeType; internal set => attributeType = value; }
    public float Amount { get => amount; internal set => amount = value; }

    public override string ToString()
    {
        return AttributeType.ToString() + ": " + Amount.ToString();
    }
}