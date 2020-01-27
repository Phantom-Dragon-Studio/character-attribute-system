using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrePlacedCharacterPlaceHolder : MonoBehaviour
{
    [SerializeField] private CharacterSheet[] sheets = default;

    void Awake()
    {
        for (int i = 0; i < sheets.Length; i++)
        {
            var t = transform;
            CharacterFactory.Create(sheets[i].Prefab, t.position, t.rotation);
            t.Translate(new Vector3(i+1,0,0));
        }
    }
}
