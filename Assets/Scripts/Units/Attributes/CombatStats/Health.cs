using System;
using UnityEngine;

public class Health : IHealth
{
    public float CurrentHealth { get; private set; }
    public float MaxHealth { get; private set; }
    public ICombatController CombatController { get; }

    public Health(ICombatController controllerToWatch)
    {
        CombatController = controllerToWatch;
        controllerToWatch.CombatStats.MaxHealth.Calculated += (sender, args) => GetMaxHealth(args.Value); //TODO Unsubscribe from onHealedEvent
        controllerToWatch.Character.Healed += (sender, args) => ApplyCurrentHealthIncrease(args.Amount); //TODO Unsubscribe from onHealedEvent
    }

    private void GetMaxHealth(float maxHealthStatValue)
    {
        MaxHealth = maxHealthStatValue * 1000;
        Debug.Log("Retrieving max health value from MaxHealth Combat Stat...");
    }

    private void ApplyCurrentHealthIncrease(float amount)
    {
        //TODO ~ Add BonusHealingReceived & HealingReduced logic here.
        Debug.Log("Healed EVENT: Increasing " + CombatController.Character.GeneralObjectInformation.Name + "'s health by " + amount.ToString());
        CurrentHealth += amount;

        if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth; //TODO Make MaxHealth get initialized first to avoid health stuck at 0
        Debug.Log("Current: " + CurrentHealth);
        Debug.Log("Max: " + MaxHealth);
    }
}