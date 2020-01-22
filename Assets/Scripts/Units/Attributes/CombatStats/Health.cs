using System;
using UnityEngine;

public class CS_Health : IHealth, ICombatStat
{
    public float Value { get; private set; }
    public float CurrentHealth => Value;
    public ICombatController CombatController { get; private set; }
    public CombatStatType CombatStatType => CombatStatType.MaxHealth;
    public float MaxHealth { get; set; }

    public CS_Health(ICombatController controllerToWatch)
    {
        CombatController = controllerToWatch;
        //TODO Unsubscribe from onHealedEvent
        ////CombatController.Healed += (sender, args) => Calculate(args.Amount);
        //CharacterToMonitor.League.PrimaryAttribute.Changed += (sender, args) => Calculate(args.Amount);
        //Calculate(CharacterToMonitor.League.PrimaryAttribute);
    }

    private void Calculate(float amount)
    {
        Debug.Log("HEALING!");
        //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
        Debug.Log("Increasing health of " + CombatController + " by " + amount.ToString());
        Value += amount;

        if (Value > MaxHealth) Value = MaxHealth;
    }
}