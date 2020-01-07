using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Inherits from unit and implements the IControllable, and IHero interfaces as well as the IUnit interface which comes with it's inheritance.
/// </summary>
public class Hero : Unit, IHero
{
    public Hero(CharacterSheet sheet) : base(sheet)
    {
    }

    void Start()
    {

    }
}
