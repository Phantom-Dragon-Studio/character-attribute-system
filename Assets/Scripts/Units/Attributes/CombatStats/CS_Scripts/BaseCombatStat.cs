using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCombatStat
{
    protected abstract void Calculate(ICharacter character);

    public abstract override string ToString();
}
