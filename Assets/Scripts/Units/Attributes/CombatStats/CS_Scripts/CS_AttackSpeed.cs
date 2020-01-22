using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_AttackSpeed : ICombatStat
{
    private float amount = 0.00f;
    public CS_AttackSpeed(ICombatController combatController)
    {
        CombatController = combatController;
        CombatController.Attributes.Agility.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    public float Value { get => amount; set => amount = value; }
    public ICombatController CombatController { get; set; }
    public CombatStatType CombatStatType { get => CombatStatType.AttackSpeed; }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if(combatController.League is Rogue )
        //{
        //    Value = combatController.Attributes.Agility.Amount + combatController.Attributes.Endurance.Amount * 0.8f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility & Endurance: " + Value);
        //}
        //if (combatController.League is Warrior)
        //{
        //    Value = combatController.Attributes.Agility.Amount * 0.6f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (combatController.League is Wizard)
        //{
        //    Value = combatController.Attributes.Agility.Amount * 0.5f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + combatController.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Attack Speed: " + amount;
    }
}
