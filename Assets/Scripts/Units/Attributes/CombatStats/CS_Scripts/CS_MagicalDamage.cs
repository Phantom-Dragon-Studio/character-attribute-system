using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_MagicalDamage : ICombatStat
{
    private float amount = 0.00f;
    private ICombatController characterToMonitor = default;

    public CS_MagicalDamage(ICombatController characterToMonitor)
    {
        CombatController = characterToMonitor;
        characterToMonitor.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    public float Value { get => amount; set => amount = value; }
    public ICombatController CombatController { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.MagicalDamage; }

    void Calculate(ICharacterAttribute influentialattribute)
    {
        //if (character.League is Rogue)
        //{
        //    Value = influentialattribute.Amount * 0.6f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
        //if (character.League is Warrior)
        //{
        //    Value = influentialattribute.Amount * 0.5f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
        //if (character.League is Wizard)
        //{
        //    Value = (influentialattribute.Amount) * 1.5f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
