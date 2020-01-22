using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTER : MonoBehaviour
{

    public float agi = 1000;
    private ICharacter[] u;
    private IAbility abilityToCast;
    private CharacterLeague cl;
    private IAbilityHandler abHand;
    // Start is called before the first frame update
    void Start()
    {
        u = FindObjectsOfType<Character>();

        for (int i = 0; i < u.Length; i++)
        {
            //Debug.Log(u[i].GeneralObjectInformation.Name);
            //Debug.Log(u[i].CharacterDescription);
            //Debug.Log(u[i].Attributes.Agility);
            //Debug.Log(u[i].Attributes.Strength);
            //Debug.Log(u[i].Attributes.Wisdom);
            //Debug.Log(u[i].Attributes.Endurance);
        }
        var ch = u[0];
        //ch.Attributes.UpdateAtribute(AttributeType.Agility, 32);
        //ch.Attributes.UpdateAtribute(AttributeType.Strength, 25);
        //ch.Attributes.UpdateAtribute(AttributeType.Wisdom, 15);
        //ch.Attributes.UpdateAtribute(AttributeType.Endurance, 21);
        cl = FindObjectOfType<CharacterLeague>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Ability 1 Activating...");
            cl.AbilityHandler.CastAbility(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Ability 2 Activating...");

            cl.AbilityHandler.CastAbility(1);
        }
    }
}
