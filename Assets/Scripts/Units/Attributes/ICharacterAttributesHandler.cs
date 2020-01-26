using System.Collections.Generic;
using UnityEngine;

public interface ICharacterAttributesHandler
{
    void UpdateAttribute(TypeValuePair<AttributeType, float> attribute);

    void AddAttribute(TypeValuePair<AttributeType, float> attribute);

    ICharacterAttribute Agility { get; }
    ICharacterAttribute Strength { get; }
    ICharacterAttribute Wisdom { get; }
    ICharacterAttribute Endurance { get; }
}
