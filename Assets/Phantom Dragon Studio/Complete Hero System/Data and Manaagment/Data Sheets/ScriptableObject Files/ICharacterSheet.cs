using PhantomDragonStudio.HeroSystem;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacterSheet
    {
        ICharacterAttribute[] Attributes { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICharacterLeague League { get; }
    }
}
