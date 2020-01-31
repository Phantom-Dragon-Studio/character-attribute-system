﻿using Phantom_Dragon_Studio.Hero_System;

namespace Phantom_Dragon_Studio.Hero_System
{
    /// <summary>
    /// What is CharacterLeague and what is it responsible for?
    /// Tells the CharacterLeague's specific factory type that it needs to generate stats and place them inside of our array.
    /// </summary>
    public abstract class CharacterLeague : ICharacterLeague
    {
        public abstract CharacterLeagueType LeagueType { get; }

        public abstract ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate);


        public override string ToString()
        {
            return LeagueType.ToString();
        }
    }
}
