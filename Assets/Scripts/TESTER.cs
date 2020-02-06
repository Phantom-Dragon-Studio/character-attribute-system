﻿using PhantomDragonStudio.Ability_System;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;

public class TESTER : MonoBehaviour
{
    private AbilityController abController;
    // Start is called before the first frame update
    void Start()
    {
        abController = FindObjectOfType<AbilityController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Ability 1 Activating...");
            abController.AbilityHandler.CastAbility(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Ability 2 Activating...");

            abController.AbilityHandler.CastAbility(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Character c = GameObject.Find("Main Character(Clone)").GetComponent<Character>();
            c.Heal(10);
            
            Debug.Log("C " + c.Health.CurrentHealth);
            Debug.Log("M " + c.Health.MaxHealth);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Attempting to increase Talent Point Level!!");
            TalentTreeHandler tp = FindObjectOfType<TalentTreeHandler>();
            tp.UpgradeTalent(0,0);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Clearing Talent Points!");
            TalentTreeHandler tp = FindObjectOfType<TalentTreeHandler>();
            tp.ResetTalentPointsInTree(0);
        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("DAMAGE!");
            Character c = GameObject.Find("Main Character(Clone)").GetComponent<Character>();
            c.Damage(50);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("HEAL!");
            Character c = GameObject.Find("Main Character(Clone)").GetComponent<Character>();
            c.Heal(50);
        }
    }
}
