using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterFactory
{
    public static GameObject Create(CharacterSheet sheet, CharacterLeague league)
    {
        //TODO Add in object pooling.
        return GameObject.Instantiate(sheet.Prefab);
        //var temp = newCharGO.GetComponent<Character>();
        //return temp;
    }
}
