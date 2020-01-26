using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterFactory
{

    public static GameObject Create(GameObject prefab, Vector3 location, Quaternion rotation)
    {
        //TODO Add in object pooling.
        GameObject GO = GameObject.Instantiate(prefab);
        Character character = GO.GetComponent<Character>();
        character.Construct();
        character.transform.position = location;
        character.transform.rotation = rotation;
        return GO;
    }
}
