using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// What is  CharacterClass and what is it responsible for?
/// 
/// It is responsible for storing the abiltiy handler and the ability handler will be incharge of storing the usable abilities.
/// Just like we do with attributes on the base Character c# class.
/// </summary>
public abstract class CharacterClass : ICharacterClass
{
    List<ScriptableObject> abilityDataList = new List<ScriptableObject>();

    public void GetAbilities()
    {
        
    }

    public override string ToString()
    {
        return "Character Class: Base";
    }
}
