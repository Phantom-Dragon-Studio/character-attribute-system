using System;
using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Hero_System
{
    public interface ICharacter
    {
        ICharacterSheet CharacterSheet { get; }
        GeneralObjectInformation GeneralObjectInformation { get; }
        ICombatController CombatController { get; }
        ICharacter Construct(CombatController combatController, Health health);
        void Heal(float amount);
        event EventHandler<Character.HealedEventArgs> Healed;
    }
}
