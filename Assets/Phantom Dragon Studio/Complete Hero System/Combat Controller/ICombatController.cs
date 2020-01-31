namespace Phantom_Dragon_Studio.Hero_System
{
    public interface ICombatController
    {
        ICharacter Character { get; }
        ICharacterAttributesHandler Attributes { get;}
        ICombatStatsHandler CombatStats { get;}
    }
}