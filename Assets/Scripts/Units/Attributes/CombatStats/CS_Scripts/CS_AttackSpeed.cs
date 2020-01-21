using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_AttackSpeed : ICombatStat
{
    private float amount = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_AttackSpeed(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Agility.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => amount; set => amount = value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.AttackSpeed; }

    void Calculate(ICharacter character)
    {
        if(character.League is Rogue )
        {
            Value = character.Attributes.Agility.Amount + character.Attributes.Endurance.Amount * 0.8f;
            Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.CharacterName + "'s Agility & Endurance: " + Value);
        }
        if (character.League is Warrior)
        {
            Value = character.Attributes.Agility.Amount * 0.6f;
            Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.CharacterName + "'s Agility: " + Value);
        }
        if (character.League is Wizard)
        {
            Value = character.Attributes.Agility.Amount * 0.5f;
            Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.CharacterName + "'s Agility: " + Value);
        }
    }

    public override string ToString()
    {
        return "Attack Speed: " + amount;
    }
}
