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

    public event EventHandler<AttributeChangedEventArgs> Changed;

    public override string ToString()
    {
        return AttributeType.ToString() + ": " + Amount.ToString();
    }

    public void UpdateValue(ICharacter character, float value)
    {
        this.Amount += value;
        Changed?.Invoke(this, new AttributeChangedEventArgs(character));
    }

    public class AttributeChangedEventArgs : EventArgs
    {
        public AttributeChangedEventArgs(ICharacter character)
        {
            Character = character;
        }

        public ICharacter Character { get; private set; }
    }
}