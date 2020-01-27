using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : CharacterLeague
{
    public override string ToString()
    {
        return "Warrior";
    }

    public override ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate)
    {
        throw new System.NotImplementedException();
    }
}
