using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PhysicalDefense : ICombatStat
{
    private float amount = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_PhysicalDefense(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Strength.Changed += (sender, args) => Calculate(args.Character);
        characterToMonitor.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => amount; set => amount = value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.PhysicalDefense; }

    void Calculate(ICharacter character)
    {
        if (character.League is Rogue)
        {
            Value = character.Attributes.Strength.Amount;
            Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.CharacterName + "'s Strength: " + Value);
        }
        if (character.League is Warrior)
        {
            Value = character.Attributes.Strength.Amount * 0.9f;
            Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.CharacterName + "'s Agility: " + Value);
        }
        if (character.League is Wizard)
        {
            Value = character.Attributes.Wisdom.Amount * 0.5f;
            Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.CharacterName + "'s Wisdom: " + Value);
        }
    }

    public override string ToString()
    {
        return "Attack Speed: " + amount;
    }
}
