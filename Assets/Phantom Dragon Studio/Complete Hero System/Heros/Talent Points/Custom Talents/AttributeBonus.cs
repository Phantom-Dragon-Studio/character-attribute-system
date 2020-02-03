using PhantomDragonStudio.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [CreateAssetMenu(fileName = "New Talent Point", menuName = "Phantom Dragon Studio/Talents/Attribute Bonus Talent", order = 2)]
    public class AttributeBonus : BaseTalentPoint
    {
        AttributeType AttributeType { get => attributeType; set => attributeType = value; }

        [Header("Attribute Details")]
        [SerializeField] private AttributeType attributeType;
        [SerializeField] private float bonusPerPoint = default;
        
        private float value;

        public override void PerformFunctionality()
        {
            value = bonusPerPoint * CurrentLevel;
            Debug.Log("Increasing " + attributeType + " by " + bonusPerPoint * CurrentLevel);
            Debug.Log(Container.Character.CharacteristicController);

            Container.Character.CharacteristicController.Attributes.UpdateAttribute(attributeType, value);
            Debug.Log(Container.Character.CharacteristicController.Attributes.Agility);
        }

        public override void StopFunctionality()
        {
            Container.Character.CharacteristicController.Attributes.UpdateAttribute(attributeType, -value);
            Debug.Log(Container.Character.CharacteristicController.Attributes.Agility);
        }
    }
}