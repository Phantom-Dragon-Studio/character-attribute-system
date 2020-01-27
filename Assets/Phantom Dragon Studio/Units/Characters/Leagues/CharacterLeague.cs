using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// What is  CharacterClass and what is it responsible for?
/// Generates and 
/// 
/// </summary>
public abstract class CharacterLeague : ICharacterLeague
{

    public override string ToString()
    {
        return "Character Class:" + this.ToString();
    }

    public abstract ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate);
}
