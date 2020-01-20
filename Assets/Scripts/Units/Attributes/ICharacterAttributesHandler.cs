using System.Collections.Generic;
using UnityEngine;

public interface ICharacterAttributesHandler
{
    void UpdateAllAttributes(ICharacter character, ICharacterAttribute[] attributes);

    void UpdateAtribute(ICharacter character, AttributeType type, float amount);

    void AddAttribute(ICharacterAttribute attribute);

    ICharacterAttribute Agility { get; }
    ICharacterAttribute Strength { get; }
    ICharacterAttribute Wisdom { get; }
    ICharacterAttribute Endurance { get; }
}
