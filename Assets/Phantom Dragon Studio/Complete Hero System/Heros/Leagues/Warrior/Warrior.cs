namespace PhantomDragonStudio.HeroSystem
{
    public class Warrior : CharacterLeague
    {
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Warrior;

        public override ICombatStat[] GenerateCombatStats(ICharacteristicController characteristicController, ICombatStat[] emptyArrayToPopulate)
        {
            return WarriorCombatStatFactory.Create(characteristicController, emptyArrayToPopulate);
        }
    }
}