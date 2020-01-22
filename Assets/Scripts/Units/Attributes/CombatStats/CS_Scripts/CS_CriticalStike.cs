using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_CriticalStrike : ICombatStat
{
    private float amount = 0.00f;

    public float Value { get; set; }
    public ICombatController CombatController { get; set; }
    public CombatStatType CombatStatType { get => CombatStatType.CriticalStrikeChance; }

    public CS_CriticalStrike(ICombatController combatControllerToWatch)
    {
        combatControllerToWatch.Attributes.Agility.Changed += (sender, args) => Calculate(args.CharacterAttribute);
        combatControllerToWatch.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if (character.League is Rogue)
        //{
        //    Value = character.Attributes.Agility.Amount * 0.8f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (character.League is Warrior)
        //{
        //    Value = character.Attributes.Agility.Amount;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Agility: " + Value);
        //}
        //if (character.League is Wizard)
        //{
        //    Value = character.Attributes.Agility.Amount * 0.6f * character.Attributes.Wisdom.Amount;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom & Agility: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
