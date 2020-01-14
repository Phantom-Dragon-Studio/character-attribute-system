using System;
using UnityEngine;

/// <summary>
/// This class is strictly a data container containing a pair of values, but is more managable than using a key value pair.
/// </summary>
public enum AttributeType
{
    None,
    Agility,
    Strength,
    Wisdom,
    Endurance,
}

[System.Serializable]
public class CharacterAttribute : ICharacterAttribute
{
    [SerializeField] private AttributeType attributeType;
    [SerializeField] private float amount;

    public AttributeType AttributeType { get => attributeType; set => attributeType = value; }
    public float Amount { get => amount; set => amount = value; }

    public override string ToString()
    {
        return AttributeType.ToString() + ": " + Amount.ToString();
    }
}