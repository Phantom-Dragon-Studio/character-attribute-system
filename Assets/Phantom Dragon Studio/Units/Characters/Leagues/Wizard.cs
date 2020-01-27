using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : CharacterLeague
{

    public override string ToString()
    {
        return "Wizard";
    }

    public override ICombatStat[] GenerateCombatStats(ICombatController combatController, ICombatStat[] emptyArrayToPopulate)
    {
        throw new System.NotImplementedException();
    }
}
