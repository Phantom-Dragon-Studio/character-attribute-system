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
    [SerializeField] private AbilityInformation[] currentAbilities = default;

    private IAbilityHandler abilityHandler;
    private IAttackStyle attackStyle;
    public IAttackStyle AttackStyle { get => attackStyle; private set => attackStyle = value; }
    public IAbilityHandler AbilityHandler { get => abilityHandler; private set => abilityHandler = value; }

    public override string ToString()
    {
        return "Character Class: Base" + "Character Specialization: " + AbilityHandler;
    }

    private void Awake()
    {
        abilityHandler = AbilityHandlerFactory.Create(currentAbilities);
    }

    private void Start()
    {

        //TODO Remove
        abilityHandler.CastAbility(0);
        abilityHandler.CastAbility(1);
    }
}
