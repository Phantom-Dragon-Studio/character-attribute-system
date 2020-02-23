using System.Linq;
using PhantomDragonStudio.Ability_System;
using PhantomDragonStudio.HeroSystem;
using UnityEngine;
using PhantomDragonStudio.PoolingSystem;

public class TESTER : MonoBehaviour
{
    private AbilityController abController;
    private Character c;
    private TalentTreeHandler tp;
    private TalentTreeHandler tp2;
    // Start is called before the first frame update
    void Start()
    {
        abController = FindObjectOfType<AbilityController>();
        c = GameObject.Find("Main Character(Clone)").GetComponent<Character>();
        tp = c.GetComponent<TalentTreeHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Debug.Log("Ability 1 Activating...");
            abController.AbilityHandler.CastAbility(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Debug.Log("Ability 2 Activating...");

            abController.AbilityHandler.CastAbility(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            tp2 = FindObjectOfType<TalentTreeHandler>();
            if (tp2 == tp)
            {
                Destroy(tp.gameObject);
                tp2 = FindObjectOfType<TalentTreeHandler>();
            }
            tp2.UpgradeTalent(0,0);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            // Debug.Log("Attempting to increase Talent Point Level!!");
            tp.UpgradeTalent(0,0);
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            // Debug.Log("Attempting to increase Talent Point Level!!");
            tp.UpgradeTalent(0,1);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            // Debug.Log("Attempting to increase Talent Point Level!!");
            tp.UpgradeTalent(0,2);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Clearing Talent Points!");
            tp.ResetTalentPointsInTree(0);
        }

        else if (Input.GetKeyDown(KeyCode.Q))
        {
            c.TakeDamage(50);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            c.RestoreHealth(50);
        }
    }
}
