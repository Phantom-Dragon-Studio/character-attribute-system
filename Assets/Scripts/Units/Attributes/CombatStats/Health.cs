using System;
using UnityEngine;

public class CS_Health : IHealth, ICombatStat
{
    public float Value { get; private set; }
    public float CurrentHealth => Value;
    public ICharacter CharacterToMonitor { get; private set; }
    public CombatStatType CombatStatType => CombatStatType.MaxHealth;
    public float MaxHealth { get; set; }

    public CS_Health(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        //TODO Unsubscribe from onHealedEvent
        CharacterToMonitor.Healed += (sender, args) => Calculate(args.Amount);
        //CharacterToMonitor.League.PrimaryAttribute.Changed += (sender, args) => Calculate(args.Amount);
        //Calculate(CharacterToMonitor.League.PrimaryAttribute);
    }

    private void Calculate(float amount)
    {
        Debug.Log("HEALING!");
        //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
        Debug.Log("Increasing health of " + CharacterToMonitor + " by " + amount.ToString());
        Value += amount;

        //if (CharacterToMonitor.League is Rogue)
        //{
        //    MaxHealth = CharacterToMonitor.Attributes.Agility.Amount * 1.5f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + CharacterToMonitor.GeneralObjectInformation.Name + "'s Strength: " + Value);
        //}
        //if (CharacterToMonitor.League is Warrior)
        //{
        //    MaxHealth = CharacterToMonitor.Attributes.Strength.Amount * 1.5f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + CharacterToMonitor.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (CharacterToMonitor.League is Wizard)
        //{
        //    MaxHealth = CharacterToMonitor.Attributes.Wisdom.Amount * 1.5f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + CharacterToMonitor.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}

        if (Value > MaxHealth) Value = MaxHealth;
    }
}