using System;
using UnityEngine;

public class Health : IHealth
{
    private ICharacter characterToMonitor;

    public Health(int currentHealth, ICharacter characterToMonitor)
    {
        CurrentHealth = currentHealth;
        CharacterToMonitor = characterToMonitor;

        CharacterToMonitor.Healed += (sender, args) => IncreaseHealth(args.Amount);
    }

    public int CurrentHealth { get; private set; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }


    private void IncreaseHealth(int amount) //Take healingReceived statusEffects as a param here.
    {
        //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
        Debug.Log("Increasing health of " + characterToMonitor + " by " + amount.ToString());
        CurrentHealth += amount;
    }
}
