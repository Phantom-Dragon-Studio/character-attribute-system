using System;
using Phantom_Dragon_Studio.Tools;

namespace Phantom_Dragon_Studio.Hero_System
{
    public interface ICharacterAttribute
    {
        event EventHandler<CharacterAttribute.AttributeChangedEventArgs> Changed;

        TypeValuePair<AttributeType, float> AttributeInfo { get; }
        void UpdateValue(float value);

        string ToString();
    }
}