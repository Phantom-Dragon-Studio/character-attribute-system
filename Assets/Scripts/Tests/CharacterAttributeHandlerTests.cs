using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
// `yield return null;` to skip a frame.
namespace Tests
{
    public class CharacterAttributeHandlerTests
    {
        CharacterSheet sheetToTest;
        ICharacterAttributesHandler CharAtHand;

        [SetUp]
        public void Setup()
        {
            sheetToTest = new CharacterSheet();
            CharAtHand = new CharacterAttributesHandlerFactory().Create(sheetToTest.Attributes);
        }

        [Test] public void MathIsStillReal_1_IsEqual_To1()
        {
            int t = 1;
            Assert.AreEqual(t, 1);
        }

        [Test] public void AttributeType_AgilityAndStrength_AreNotEqual()
        {
            Assert.AreNotEqual(CharAtHand.Agility, AttributeType.Strength);
        }

        [Test] public void AttributeValue_Wisdom_IsEqual_ToZero()
        {
            Assert.AreEqual(CharAtHand.Wisdom.Amount, 0);
        }

        [Test] public void UpdateAttributeFunction_AreEqual_10()
        {
            var temp = CharAtHand.Endurance.Amount;
            CharAtHand.UpdateAtribute(AttributeType.Endurance, 10);
            Assert.AreEqual(temp + 10 , CharAtHand.Endurance.Amount);
        }
    }
}
