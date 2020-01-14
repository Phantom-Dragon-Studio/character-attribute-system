using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
using Moq;

namespace Tests
{
    public class CharacterTests
    {
        ICharacter character;

        [SetUp]
        public void CharacterTestsSimplePasses()
        {

        }

        //[Test]
        //public IEnumerator CharacterTestsWithEnumeratorPasses()
        //{
        //    // Use the Assert class to test conditions.
        //    // Use yield to skip a frame.
        //    yield return null;
        //}

        [Test]
        public void Raises_Event_On_Heal()
        {

            character = Substitute.For<ICharacter>();

            var amount = -1;
            character.Healed += (sender, args) => { amount = args.Amount; };
            character.Heal(0);
            Assert.AreEqual(0, amount);
        }
    }
}
