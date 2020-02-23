﻿using PhantomDragonStudio.PoolingSystem;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    public static class CharacterFactory
    {
        public static ICharacter Create(Character prefab, CharacterPool pool = null)
        {
            ICharacter character = GameObject.Instantiate(prefab);
            CharacteristicController characteristicController = new CharacteristicController(character);
            character.Construct(characteristicController);
            if (pool != null)
            {
                pool.AddToPool(character);
            }
            return character;
        }
    }
}