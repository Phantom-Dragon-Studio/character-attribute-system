using System;
using UnityEngine;

/// <summary>
/// This class is strictly a data container containing a pair of values, but is more managable than using a key value pair.
/// </summary>
public enum AttributeType
{
    _None,
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

    public event EventHandler<AttributeChangedEventArgs> Changed;

    public void UpdateValue(ICharacter combatController, float value)
    {
        this.Amount += value;
        Changed?.Invoke(this, new AttributeChangedEventArgs(this));
    }

    public class AttributeChangedEventArgs : EventArgs
    {
        public AttributeChangedEventArgs(ICharacterAttribute characterAttribute)
        {
            CharacterAttribute = characterAttribute;
        }

        public ICharacterAttribute CharacterAttribute { get; private set; }
    }
}