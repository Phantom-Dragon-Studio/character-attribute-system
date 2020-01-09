using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// What is  CharacterClass and what is it responsible for?
/// 
/// It is responsible for storing the abiltiy handler and the ability handler will be incharge of storing the usable abilities.
/// Just like we do with attributes on the base Character c# class.
/// </summary>

[RequireComponent(typeof(Character))]
public abstract class CharacterLeague : MonoBehaviour, ICharacterLeague
{
    private Dictionary<IAbility, IAbility> abilityList = new Dictionary<IAbility, IAbility>();
    public Dictionary<IAbility, IAbility> GetAbilities => abilityList;

    private IAttackStyle attackStyle;
    public IAttackStyle AttackStyle { get => attackStyle; private set => attackStyle = value; }


    public override string ToString()
    {
        return "Character Class: Base";
    }
}
