﻿namespace PhantomDragonStudio.HeroSystem
{
    public class Rogue : CharacterLeague
    {
        public override CharacterLeagueType LeagueType => CharacterLeagueType.Rogue;

        public override ICombatStat[] GenerateCombatStats(ICharacteristicController characteristicController, ICombatStat[] emptyArrayToPopulate)
        {
            return RogueCombatStatFactory.Create(characteristicController, emptyArrayToPopulate);
        }
    }
}