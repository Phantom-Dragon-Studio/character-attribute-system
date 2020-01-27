using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public static CombatManager _instance;

    public static CombatManager Instance {  get { if (_instance == null) _instance = FindObjectOfType<CombatManager>(); return _instance; } }

    [SerializeField] private  CombatStat_Modifiers_Sheet rogueSettings;
    public CombatStat_Modifiers_Sheet RogueStatSettings { get => rogueSettings; set => rogueSettings = value; }

    [SerializeField] private CombatStat_Modifiers_Sheet warriorSettings;
    public CombatStat_Modifiers_Sheet WarriorStatSettings { get => warriorSettings; set => warriorSettings = value; }

    [SerializeField] private CombatStat_Modifiers_Sheet wizardSettings;
    public CombatStat_Modifiers_Sheet WizardStatSettings { get => wizardSettings; set => wizardSettings = value; }

    internal float RogueCombatStatModifiers(CombatStatType combatStatType)
    {
        return RogueStatSettings.Settings[combatStatType];
    }
}
