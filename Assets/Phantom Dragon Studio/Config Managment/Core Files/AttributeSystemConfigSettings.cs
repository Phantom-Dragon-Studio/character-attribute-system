using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameDifficulty { Easy, Medium, Hard, Impossible }

[CreateAssetMenu(fileName = "New CAS Config Settings", menuName = "Phantom Dragon Studio/CAS Config Settings", order = 0)]
public class AttributeSystemConfigSettings : ScriptableObject
{
    [SerializeField] GameDifficulty gameDifficulty;

    [Header("Rogue")]
    [SerializeField] public float Rogue_AgilityPerLevel;
    [SerializeField] public float rogue_StrengthPerLevel;
    [SerializeField] public float rogue_WisdomPerLevel;
    [SerializeField] public float rogue_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] public float rogue__A_D_C_Multiplier;

    [Header("Warrior")]
    [SerializeField] public float warrior_AgilityPerLevel;
    [SerializeField] public float warrior_StrengthPerLevel;
    [SerializeField] public float warrior_WisdomPerLevel;
    [SerializeField] public float warrior_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] public float warrior_A_D_C_Multiplier;

    [Header("Wizard")]
    [SerializeField] public float wizard_AgilityPerLevel;
    [SerializeField] public float wizard_StrengthPerLevel;
    [SerializeField] public float wizard_WisdomPerLevel;
    [SerializeField] public float wizard_EndurancePerLevel;
    [SerializeField] [Range(-1, 1)] public float wizard_A_D_C_Multiplier;
}
