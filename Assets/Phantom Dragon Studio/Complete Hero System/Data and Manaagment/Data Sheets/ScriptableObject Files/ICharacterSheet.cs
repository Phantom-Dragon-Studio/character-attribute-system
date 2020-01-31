using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Hero_System
{
    public interface ICharacterSheet
    {
        ICharacterAttribute[] Attributes { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacterLeague League { get; }
    }
}
