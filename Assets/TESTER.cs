using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTER : MonoBehaviour
{
    private IUnit[] u;
    // Start is called before the first frame update
    void Start()
    {
        u = FindObjectsOfType<Unit>();
        for (int i = 0; i < u.Length; i++)
        {
            Debug.Log(u[i].CharacterName);
            Debug.Log(u[i].CharacterDescription);
            Debug.Log(u[i].CharacterSprite.name);
            Debug.Log(u[i].GetAttributes.Agility);
            Debug.Log(u[i].GetAttributes.Strength);
            Debug.Log(u[i].GetAttributes.Wisdom);
            Debug.Log(u[i].GetAttributes.Endurance);

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
