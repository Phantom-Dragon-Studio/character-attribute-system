using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterFactory
{

    public static GameObject Create(GameObject prefab, Vector3 location, Quaternion rotation)
    {
        //TODO Add in object pooling.
        GameObject GO = GameObject.Instantiate(prefab);
        ICharacter character = GO.GetComponent<Character>() as ICharacter;
        var combatController = new CombatController(character);
        character.Construct(combatController, new Health(combatController));
        GO.transform.position = location;
        GO.transform.rotation = rotation;

        combatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Agility, 10));
        combatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Strength, 10));
        combatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Wisdom, 10));
        combatController.Attributes.UpdateAttribute(new TypeValuePair<AttributeType, float>(AttributeType.Endurance, 10));

        return GO;
    }
}
