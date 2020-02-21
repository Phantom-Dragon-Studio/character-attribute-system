using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public static class CharacterFactory
    {

        public static ICharacter Create(Character prefab, Vector3 location, Quaternion rotation)
        {
            ICharacter character = GameObject.Instantiate(prefab, location, rotation);
            CharacteristicController characteristicController = new CharacteristicController(character);
            character.Construct(characteristicController);

            //TODO Remove Test Code
            character.CharacteristicController.Attributes.Agility.UpdateValue(1);
            character.CharacteristicController.Attributes.Strength.UpdateValue(1);
            character.CharacteristicController.Attributes.Wisdom.UpdateValue(1);
            character.CharacteristicController.Attributes.Endurance.UpdateValue(1);
            
            return character;
        }
    }
}