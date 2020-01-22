using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PhysicalDamage : ICombatStat
{
    private float amount = 0.00f;
    public float Value { get; set; }
    public ICombatController CombatController { get; set; }
    public CombatStatType CombatStatType { get => CombatStatType.PhysicalDamage; }

    public CS_PhysicalDamage(ICombatController combatControllerToWatch)
    {
        combatControllerToWatch.Attributes.Agility.Changed += (sender, args) => Calculate(args.CharacterAttribute);
        combatControllerToWatch.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
        combatControllerToWatch.Attributes.Strength.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if (character.League is Rogue)
        //{
        //    Value = influentialAttribute.Amount * 0.9f;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s " + character.Attributes.Agility + Value);
        //}
        //if (character.League is Warrior)
        //{
        //    Value = influentialAttribute.Amount * 1.1f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s "+ character.Attributes.Strength + Value);
        //}
        //if (character.League is Wizard)
        //{
        //    Value = influentialAttribute.Amount * 0.8f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s " + character.Attributes.Wisdom + Value);
        //}
    }

    public override string ToString()
    {
        return "Critical Strike Chance: " + amount;
    }
}
