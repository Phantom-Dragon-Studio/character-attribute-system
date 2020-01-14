using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

// A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
// `yield return null;` to skip a frame.
namespace Tests
{
    [TestFixture]
    public class CharacterAttributeHandlerTests
    {
        ICharacterSheet sheetToTest;
        ICharacterAttributesHandler attributesHandler;

        [SetUp]
        public void Setup()
        {
            ICharacterAttribute at1 = CharacterAttributeFactory.Create(AttributeType.Agility, 5);
            ICharacterAttribute at2 = CharacterAttributeFactory.Create(AttributeType.Strength, 15);
            ICharacterAttribute at3 = CharacterAttributeFactory.Create(AttributeType.Wisdom, 25);
            ICharacterAttribute at4 = CharacterAttributeFactory.Create(AttributeType.Endurance, 30);

            ICharacterAttribute[] characterAttributes = new ICharacterAttribute[4];
            characterAttributes[0] = at1;
            characterAttributes[1] = at2;
            characterAttributes[2] = at3;
            characterAttributes[3] = at4;

            sheetToTest = Substitute.For<ICharacterSheet>();
            sheetToTest.Attributes.Returns(characterAttributes);

            attributesHandler = Substitute.For<ICharacterAttributesHandler>();
            attributesHandler.MyAttributes.Returns(characterAttributes);
        }

        [Test] public void MathIsStillReal_1_IsEqual_To1()
        {
            int t = 1;
            Assert.AreEqual(t, 1);
        }

        [Test] public void AttributeType_AgilityAndStrength_AreNotEqual()
        {
            Assert.AreNotEqual(attributesHandler.Agility, AttributeType.Strength);
        }

        [Test] public void AttributeValue_Wisdom_IsEqual_ToZero()
        {
            Assert.AreEqual(attributesHandler.Wisdom.Amount, 0);
        }

        [Test] public void UpdateAttributeFunction_AreEqual_10()
        {
            attributesHandler.Endurance.Amount.Returns(10);
            Assert.AreEqual(attributesHandler.Endurance.Amount, 10);
        }
    } 
}
