using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Unit, IControllable, IHero
{
    public Hero(CharacterSheet sheet, CharacterAttributes characterStats) : base(sheet, characterStats)
    {
    }

    void Start()
    {

    }

    public void ProcessInput()
    {
        Debug.Log("Would be processing movement rn...");
    }
}
