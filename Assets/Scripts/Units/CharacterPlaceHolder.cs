using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlaceHolder : MonoBehaviour
{
    public CharacterSheet characterToSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        CharacterFactory.Create(characterToSpawn, transform.position, transform.rotation);
    }
}
