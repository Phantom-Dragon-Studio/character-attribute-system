﻿using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private static CombatManager _instance;

    [SerializeField] private CombatStat_Modifiers_Sheet rogueSettings;
    public CombatStat_Modifiers_Sheet RogueStatSettings { get => rogueSettings; set => rogueSettings = value; }

    [SerializeField] private CombatStat_Modifiers_Sheet warriorSettings;
    public CombatStat_Modifiers_Sheet WarriorStatSettings { get => warriorSettings; set => warriorSettings = value; }

    [SerializeField] private CombatStat_Modifiers_Sheet wizardSettings;
    public CombatStat_Modifiers_Sheet WizardStatSettings { get => wizardSettings; set => wizardSettings = value; }

    public Dictionary<CharacterLeagueType, CombatStat_Modifiers_Sheet> LeagueSettings = new Dictionary<CharacterLeagueType, CombatStat_Modifiers_Sheet>();

    public static CombatManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<CombatManager>();
                Initialize();
            }
            return _instance;
        }
    }

    private static void Initialize()
    {
        _instance.LeagueSettings.Add(CharacterLeagueType.Rogue, _instance.RogueStatSettings);
        _instance.LeagueSettings.Add(CharacterLeagueType.Warrior, _instance.WarriorStatSettings);
        _instance.LeagueSettings.Add(CharacterLeagueType.Wizard, _instance.WizardStatSettings);
    }

    internal float CombatStatModifiers(CharacterLeagueType league, CombatStatType stat)
    {
        return LeagueSettings[league].Settings[stat];
    }
}