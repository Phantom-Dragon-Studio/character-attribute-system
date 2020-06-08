using PhantomDragonStudio.Tools;
using PhantomDragonStudio.CombatMechanics;
using PhantomDragonStudio.Environment;

namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacter : IActivatable
    {
        int GetInstanceID();
        ICharacter Construct(ICharacteristicController characteristicController);
        ICharacterSheet CharacterSheet { get; }
        ICharacteristicController CharacteristicController { get; }
    }
}
