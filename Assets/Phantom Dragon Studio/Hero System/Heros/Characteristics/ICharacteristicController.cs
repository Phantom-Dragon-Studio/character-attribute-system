namespace PhantomDragonStudio.HeroSystem
{
    public interface ICharacteristicController
    {
        ICharacter Character { get; }
        ICharacterAttributesHandler Attributes { get;}
        ICombatStatsHandler CombatStats { get;}
    }
}