namespace PhantomDragonStudio.HeroSystem
{
    public interface ICombatController
    {
        ICharacter Character { get; }
        ICharacterAttributesHandler Attributes { get;}
        ICombatStatsHandler CombatStats { get;}
    }
}