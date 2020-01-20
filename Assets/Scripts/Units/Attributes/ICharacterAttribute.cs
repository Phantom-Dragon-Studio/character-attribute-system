using System;
using UnityEngine;

public interface ICharacterAttribute
{
    AttributeType AttributeType { get; set; }
    float Amount { get; set;  }
    string ToString();
    void UpdateValue(ICharacter character, float value);
    event EventHandler<CharacterAttribute.AttributeChangedEventArgs> Changed;
}