using UnityEngine;

public interface ICharacterAttributesHandler
{
    void UpdateAllAttributes(ICharacterAttribute[] attributes);

    void UpdateAtribute(AttributeType type, float amount);

    void AddAttribute(ICharacterAttribute attribute);

    ICharacterAttribute Agility { get; }
    ICharacterAttribute Strength { get; }
    ICharacterAttribute Wisdom { get; }
    ICharacterAttribute Endurance { get; }
}
