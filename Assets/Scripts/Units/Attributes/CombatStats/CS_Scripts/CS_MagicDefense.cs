using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_MagicDefense : ICombatStat
{
    private float amount = 0.00f;
    public float Value { get; set; }
    public ICombatController CombatController { get; set; }
    public CombatStatType CombatStatType { get => CombatStatType.MagicDefense; }
    public CS_MagicDefense(ICombatController combatControllerToWatch)
    {
        CombatController = combatControllerToWatch;
        combatControllerToWatch.Attributes.Wisdom.Changed += (sender, args) => Calculate(args.CharacterAttribute);
    }

    void Calculate(ICharacterAttribute influentialAttribute)
    {
        //if (character.League is Rogue)
        //{
        //    Value = character.Attributes.Wisdom.Amount;
        //    Debug.Log("Calculating Rogue: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
        //if (character.League is Warrior)
        //{
        //    Value = character.Attributes.Wisdom.Amount * 0.7f;
        //    Debug.Log("Calculating Warrior: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
        //if (character.League is Wizard)
        //{
        //    Value = character.Attributes.Wisdom.Amount * 1.25f;
        //    Debug.Log("Calculating Wizard: " + CombatStatType + " based upon " + character.GeneralObjectInformation.Name + "'s Wisdom: " + Value);
        //}
    }

    public override string ToString()
    {
        return "Magic Defense: " + amount;
    }
}
