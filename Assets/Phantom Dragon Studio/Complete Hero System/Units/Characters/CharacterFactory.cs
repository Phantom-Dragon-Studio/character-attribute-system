using UnityEngine;

namespace Phantom_Dragon_Studio.Hero_System
{
    public static class CharacterFactory
    {

        public static ICharacter Create(GameObject prefab, Vector3 location, Quaternion rotation)
        {
            //TODO Add in object pooling.
            ICharacter character = GameObject.Instantiate(prefab,location, rotation).GetComponent<Character>();
            CombatController combatController = new CombatController(character);
            character.Construct(combatController, new Health(combatController));
            
            //TODO Remove Test Code
            character.CombatController.Attributes.Agility.UpdateValue(10);
            character.CombatController.Attributes.Strength.UpdateValue(10);
            character.CombatController.Attributes.Wisdom.UpdateValue(10);
            character.CombatController.Attributes.Endurance.UpdateValue(10);
            
            return character;
        }
    }
}