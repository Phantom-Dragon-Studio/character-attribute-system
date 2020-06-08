using System;
using PhantomDragonStudio.Tools;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacterAttribute
    {
        event EventHandler<CharacterAttribute.AttributeChangedEventArgs> Changed;

        TypeValuePair<AttributeType, float> AttributeInfo { get; }
        void UpdateValue(float value);

        string ToString();
    }
}