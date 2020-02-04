namespace PhantomDragonStudio.HeroSystem
{
    public class Wizard : CharacterLeague
    {
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Wizard;

        public override ICombatStat[] GenerateCombatStats(ICharacteristicController characteristicController, ICombatStat[] emptyArrayToPopulate)
        {
            return WizardCombatStatFactory.Create(characteristicController, emptyArrayToPopulate);
        }
    }
}