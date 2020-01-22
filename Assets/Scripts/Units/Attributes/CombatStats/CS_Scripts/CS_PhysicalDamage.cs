using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PhysicalDamage : ICombatStat
{
    private float amount = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_PhysicalDamage(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Agility.Changed += (sender, args) => Calculate(args.Character);
        characterToMonitor.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.Character);
        characterToMonitor.Attributes.Strength.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => amount; set => amount = value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.PhysicalDamage; }

    void Calculate(ICharacter character)
    {
        if (character.League is Rogue)
        {
            Value = character.Attributes.Agility.Amount * 0.9f;
            Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s " + character.Attributes.Agility + Value);
        }
        if (character.League is Warrior)
        {
            Value = character.Attributes.Strength.Amount * 1.1f;
            Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s "+ character.Attributes.Strength + Value);
        }
        if (character.League is Wizard)
        {
            Value = (character.Attributes.Wisdom.Amount) * 0.8f;
            Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s " + character.Attributes.Wisdom + Value);
        }
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
