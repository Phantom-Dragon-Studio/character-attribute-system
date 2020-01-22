using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCombatController : MonoBehaviour
{
    public ICharacterAttributesHandler Attributes { get; private set; }

    public CharacterCombatController()
    {
        this.Attributes = CharacterAttributesHandlerFactory.Create(characterSheet.Attributes);
    }
}
