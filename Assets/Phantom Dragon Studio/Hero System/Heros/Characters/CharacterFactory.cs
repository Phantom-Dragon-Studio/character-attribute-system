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
            return character;
        }
    }
}