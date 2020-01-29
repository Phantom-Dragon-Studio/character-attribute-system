using System.Collections;
using System.Collections.Generic;
using Ability_System;
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
            Debug.Log("Displaying Health...");
            Character c = FindObjectOfType<Character>();
            c.Heal(10);
        }
    }
}
