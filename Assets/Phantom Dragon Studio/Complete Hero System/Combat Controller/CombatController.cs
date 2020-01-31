namespace PhantomDragonStudio.HeroSystem
{
    public class CombatController : ICombatController
    {
        public ICharacter Character { get; private set; }
        public ICharacterAttributesHandler Attributes { get; private set; }
        public ICombatStatsHandler CombatStats { get; private set; }


        public CombatController(ICharacter character)
        {
            Character = character;
            Attributes = CharacterAttributesHandlerFactory.Create(Character.CharacterSheet.Attributes);
            CombatStats = CombatStatHandlerFactory.Create(this, Character.CharacterSheet.League);
        }
    }
}
