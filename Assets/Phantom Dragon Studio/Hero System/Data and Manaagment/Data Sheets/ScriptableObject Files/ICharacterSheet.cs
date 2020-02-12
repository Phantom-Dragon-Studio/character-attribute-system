using PhantomDragonStudio.Tools;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacterSheet
    {
        ICharacterAttribute[] Attributes { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacterLeague League { get; }
        Character Prefab { get; }
    }
}
