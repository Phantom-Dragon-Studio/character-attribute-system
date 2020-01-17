using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterFactory
{
    public static GameObject Create(CharacterSheet sheet)
    {
        //TODO Add in object pooling.
        return GameObject.Instantiate(sheet.Prefab);

    }
}
