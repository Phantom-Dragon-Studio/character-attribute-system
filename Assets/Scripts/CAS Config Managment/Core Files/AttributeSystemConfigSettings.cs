using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameDifficulty { Easy, Medium, Hard, Impossible }

[CreateAssetMenu(fileName = "New CAS Config Settings", menuName = "Phantom Dragon Studio/New CAS Config Settings", order = 0)]
public class AttributeSystemConfigSettings : ScriptableObject
{
    [SerializeField] GameDifficulty gameDifficulty;

    [Header("Rogue")]
    [SerializeField] private float rogue_AgilityPerLevel;
    [SerializeField] private float rogue_StrengthPerLevel;
    [SerializeField] private float rogue_WisdomPerLevel;
    [SerializeField] private float rogue_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] private float rogue__A_D_C_Multiplier;

    [Header("Warrior")]
    [SerializeField] private float warrior_AgilityPerLevel;
    [SerializeField] private float warrior_StrengthPerLevel;
    [SerializeField] private float warrior_WisdomPerLevel;
    [SerializeField] private float warrior_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] private float warrior_A_D_C_Multiplier;

    [Header("Wizard")]
    [SerializeField] private float wizard_AgilityPerLevel;
    [SerializeField] private float wizard_StrengthPerLevel;
    [SerializeField] private float wizard_WisdomPerLevel;
    [SerializeField] private float wizard_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] private float wizard_A_D_C_Multiplier;
}
