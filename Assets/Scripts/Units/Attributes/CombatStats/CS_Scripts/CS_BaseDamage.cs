using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_BaseDamage : BaseCombatStat, ICombatStat
{
    private float value = 0.00f;
    private ICharacter characterToMonitor = default;
    public float Value { get => value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }

    public CombatStatType CombatStatType { get => CombatStatType.BaseDamage; }

    public CS_BaseDamage(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Strength.Changed += (sender, args) => Calculate(args.Character);
    }

    protected override void Calculate(ICharacter character)
    {
        Debug.Log("Calculating base damage based upon " + character.CharacterName + "'s " + character.Attributes.Strength);
    }

    public override string ToString()
    {
        return "Base Damage: " + value;
    }
}
