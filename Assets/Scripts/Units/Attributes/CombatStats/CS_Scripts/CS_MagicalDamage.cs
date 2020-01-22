using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_MagicalDamage : ICombatStat
{
    private float amount = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_MagicalDamage(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => amount; set => amount = value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.MagicalDamage; }

    void Calculate(ICharacter character)
    {
        if (character.League is Rogue)
        {
            Value = character.Attributes.Agility.Amount * 0.6f;
            Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        }
        if (character.League is Warrior)
        {
            Value = character.Attributes.Strength.Amount * 0.5f;
            Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        }
        if (character.League is Wizard)
        {
            Value = (character.Attributes.Wisdom.Amount) * 1.5f;
            Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        }
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
