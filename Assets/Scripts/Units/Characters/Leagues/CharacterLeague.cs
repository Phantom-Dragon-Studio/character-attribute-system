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
    private ICombatStatsHandler combatStatsHandler;
    private ICharacter character;

    public IAbilityHandler AbilityHandler { get => abilityHandler; private set => abilityHandler = value; }
    public ICombatStatsHandler CombatStats { get => combatStatsHandler; private set => combatStatsHandler = value; }
    public ICharacter Character { get => character; private set => character = value; }
    //public ICharacterAttribute PrimaryAttribute => 

    public override string ToString()
    {
        return "Character Class:" + this.ToString() + "Character Specialization: " + AbilityHandler;
    }

    private void Start()
    {
        Character = GetComponent<Character>();
        abilityHandler = AbilityHandlerFactory.Create(currentAbilities);
        CombatStats = CombatStatHandlerFactory.Create(Character);
    }
}
