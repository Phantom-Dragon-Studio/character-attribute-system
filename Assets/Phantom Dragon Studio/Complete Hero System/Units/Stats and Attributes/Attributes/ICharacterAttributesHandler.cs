using Phantom_Dragon_Studio.Tools;

namespace Phantom_Dragon_Studio.Hero_System
{
    public interface ICharacterAttributesHandler
    {
        void UpdateAttribute(TypeValuePair<AttributeType, float> attribute);

        void AddAttribute(TypeValuePair<AttributeType, float> attribute);

        ICharacterAttribute NULL { get; }
        ICharacterAttribute Agility { get; }
        ICharacterAttribute Strength { get; }
        ICharacterAttribute Wisdom { get; }
        ICharacterAttribute Endurance { get; }
    }
}
