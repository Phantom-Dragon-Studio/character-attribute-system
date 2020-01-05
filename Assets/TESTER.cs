using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTER : MonoBehaviour
{
    private Unit u;
    // Start is called before the first frame update
    void Start()
    {
        u = FindObjectOfType<Unit>();
        Debug.Log(u.CharacterName);
        Debug.Log(u.CharacterDescription);
        Debug.Log(u.CharacterSprite.name);
        Debug.Log(u.GetAttributes.Agility);
        Debug.Log(u.GetAttributes.Strength);
        Debug.Log(u.GetAttributes.Wisdom);
        Debug.Log(u.GetAttributes.Endurance);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
