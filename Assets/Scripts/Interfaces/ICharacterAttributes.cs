using UnityEngine;

public interface ICharacterAttributes
{
    void UpdateAllAttributes(Attribute[] attributes);

    void UpdateAtribute(AttributeType type, float amount);

    Attribute Agility { get; }
    Attribute Strength { get; }
    Attribute Wisdom { get; }
    Attribute Endurance { get; }
}
