using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PhysicalDefense : ICombatStat
{
    private float amount = 0.00f;
    public float Value { get; set; }
    public ICombatController CombatController { get; set; }
    public CombatStatType CombatStatType { get => CombatStatType.PhysicalDefense; }
    public CS_PhysicalDefense(ICombatController combatControllerToWatch)
    {
        CombatController = combatControllerToWatch;
        combatControllerToWatch.Attributes.Strength.Changed += (sender, args) => Calculate(args.CharacterAttribute);
        combatControllerToWatch.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if (influentialAttribute.League is Rogue)
        //{
        //    Value = influentialAttribute.Amount * 0.9f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + influentialAttribute.GeneralObjectInformation.Name + "'s Strength: " + Value);
        //}
        //if (influentialAttribute.League is Warrior)
        //{
        //    Value = influentialAttribute.Amount;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + influentialAttribute.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (influentialAttribute.League is Wizard)
        //{
        //    Value = influentialAttribute.Amount * 0.5f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + influentialAttribute.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Physical Defense: " + amount;
    }
}
