using PhantomDragonStudio.Tools;
using PhantomDragonStudio.CombatMechanics;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter
    {
        int GetInstanceID();
        ICharacter Construct(ICharacteristicController characteristicController);
        ICharacterSheet CharacterSheet { get; }
        ICharacteristicController CharacteristicController { get; }
    }
}
