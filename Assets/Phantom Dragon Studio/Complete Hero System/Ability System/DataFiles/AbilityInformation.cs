using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Ability Sheet", menuName = "Phantom Dragon Studio/Ability Sheet", order = 1)]
public class AbilityInformation : ScriptableObject
{
    [SerializeField] private GeneralObjectInformation information = default;
    [SerializeField] private AbilityInfoContainer generalAbilityInfo = default;
    [SerializeField] private StatusEffect[] statusEffects = default;

    public string AbilityName => GeneraInformation.Name;
    public string AbilityDescription => GeneraInformation.Description;
    public GeneralObjectInformation GeneraInformation => information;
    public AbilityInfoContainer GeneralAbilityInfo => generalAbilityInfo;
    public StatusEffect[] StatusEffects => statusEffects;
}
