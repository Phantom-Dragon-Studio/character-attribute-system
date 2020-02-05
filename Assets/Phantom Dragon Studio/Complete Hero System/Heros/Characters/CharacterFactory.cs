using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public static class CharacterFactory
    {

        public static ICharacter Create(GameObject prefab, Vector3 location, Quaternion rotation)
        {
            //TODO Add in object pooling.
            ICharacter character = GameObject.Instantiate(prefab,location, rotation).GetComponent<Character>();
            CharacteristicController characteristicController = new CharacteristicController(character);
            character.Construct(characteristicController, new Health(characteristicController));
            
            //TODO Remove Test Code
            character.CharacteristicController.Attributes.Agility.UpdateValue(1);
            character.CharacteristicController.Attributes.Strength.UpdateValue(1);
            character.CharacteristicController.Attributes.Wisdom.UpdateValue(1);
            character.CharacteristicController.Attributes.Endurance.UpdateValue(1);
            
            return character;
        }
    }
}