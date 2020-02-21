using PhantomDragonStudio.Tools;
using PhantomDragonStudio.CombatMechanics;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        int GetInstanceID();
        ICharacter Construct(CharacteristicController characteristicController);
        ICharacterSheet CharacterSheet { get; }
        ICharacteristicController CharacteristicController { get; }
    }
}
