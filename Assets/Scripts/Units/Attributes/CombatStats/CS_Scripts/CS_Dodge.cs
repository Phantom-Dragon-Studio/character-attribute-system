using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Dodge : ICombatStat
{
    private float amount = 0.00f;
    public float Value { get; set; }
    public ICombatController CombatController { get; set; }

    public CombatStatType CombatStatType { get => CombatStatType.DodgeChance; }

    public CS_Dodge(ICombatController combatController)
    {
        CombatController = combatController;
        CombatController.Attributes.Agility.Changed += (sender, args) => Calculate(args.CharacterAttribute);
        CombatController.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if (combatController.League is Rogue)
        //{
        //    Value = CombatController.Attributes.Agility.Amount * 0.6f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (combatController.League is Warrior)
        //{
        //    Value = CombatController.Attributes.Agility.Amount * 0.8f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (combatController.League is Wizard)
        //{
        //    Value = CombatController.Attributes.Agility.Amount + CombatController.Attributes.Wisdom.Amount * 0.5f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Dodge Chance: " + amount;
    }
}
