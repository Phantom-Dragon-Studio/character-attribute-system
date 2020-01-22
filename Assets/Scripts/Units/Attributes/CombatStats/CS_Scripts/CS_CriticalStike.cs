using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_CriticalStrike : ICombatStat
{
    private float amount = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_CriticalStrike(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Agility.Changed += (sender, args) => Calculate(args.Character);
        characterToMonitor.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => amount; set => amount = value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.CriticalStrikeChance; }

    void Calculate(ICharacter character)
    {
        if (character.League is Rogue)
        {
            Value = character.Attributes.Agility.Amount * 0.8f;
            Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Agility: " + Value);
        }
        if (character.League is Warrior)
        {
            Value = character.Attributes.Agility.Amount;
            Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Agility: " + Value);
        }
        if (character.League is Wizard)
        {
            Value = character.Attributes.Agility.Amount * 0.6f * character.Attributes.Wisdom.Amount;
            Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom & Agility: " + Value);
        }
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
