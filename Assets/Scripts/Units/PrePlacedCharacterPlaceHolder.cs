using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrePlacedCharacterPlaceHolder : MonoBehaviour
{
    public CharacterSheet characterToSpawn;
    public CharacterSheet characterToSpawn2;
    // Start is called before the first frame update
    void Awake()
    {
        CharacterFactory.Create(characterToSpawn, transform.position, transform.rotation);
        CharacterFactory.Create(characterToSpawn2, transform.position, transform.rotation);
    }
}
