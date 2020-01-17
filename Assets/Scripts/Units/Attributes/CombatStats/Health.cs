using System;
using UnityEngine;

public class Health : IHealth
{
    private ICharacter characterToMonitor;

    public Health(int currentHealth, ICharacter characterToMonitor)
    {
        CurrentHealth = currentHealth;
        CharacterToMonitor = characterToMonitor;

        //TODO Unsubscribe from onHealedEvent
        CharacterToMonitor.Healed += (sender, args) => IncreaseHealth(args.Amount);
    }

    public float CurrentHealth { get; private set; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; private set => characterToMonitor = value; }

    public void ResetHealth()
    {
        CurrentHealth = 0;
    }

    private void IncreaseHealth(float amount)
    {
        Debug.Log("HEALING!");
        //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
        Debug.Log("Increasing health of " + characterToMonitor + " by " + amount.ToString());
        CurrentHealth += amount;
    }
}
