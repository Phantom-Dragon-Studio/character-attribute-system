using System.Collections;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CharacterLeagueTests
    {
        ICharacterSheet sheetToTest;
        ICharacterAttributesHandler charAttributes;

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

            var mock = new Mock<ICharacterSheet>();
            mock.Setup(m => m.Attributes).Returns(characterAttributes);

        }

        // A Test behaves as an ordinary method
        [Test]
        public void CharacterLeagueTestsSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator CharacterLeagueTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
