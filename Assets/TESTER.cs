using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTER : MonoBehaviour
{
    private ICharacter[] u;
    // Start is called before the first frame update
    void Start()
    {
        u = FindObjectsOfType<Character>();
        for (int i = 0; i < u.Length; i++)
        {
            Debug.Log(u[i].CharacterName);
            Debug.Log(u[i].CharacterDescription);
            Debug.Log(u[i].CharacterSprite.name);
            Debug.Log(u[i].Attributes.Agility);
            Debug.Log(u[i].Attributes.Strength);
            Debug.Log(u[i].Attributes.Wisdom);
            Debug.Log(u[i].Attributes.Endurance);

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
