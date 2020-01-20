using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_AttackSpeed : ICombatStat
{
    private float value = 0.00f;
    private ICharacter characterToMonitor = default;

    public CS_AttackSpeed(ICharacter characterToMonitor)
    {
        CharacterToMonitor = characterToMonitor;
        characterToMonitor.Attributes.Agility.Changed += (sender, args) => Calculate(args.Character);
    }

    public float Value { get => value; }
    public ICharacter CharacterToMonitor { get => characterToMonitor; set => characterToMonitor = value; }
    public CombatStatType CombatStatType { get => CombatStatType.AttackSpeed; }

    void Calculate(ICharacter character)
    {
        Debug.Log("Calculating attack speed based upon " + character.CharacterName + "'s " + character.Attributes.Agility);
    }

    public override string ToString()
    {
        return "Attack Speed: " + value;
    }
}
