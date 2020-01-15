using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
using Moq;
using System;

namespace Tests
{[TestFixture]
    public class CharacterTests
    {
        ICharacter character;
        IHealth health;

        [SetUp]
        public void CharacterTestsSimplePasses()
        {
            character = Substitute.For<ICharacter>();
            health = Substitute.For<IHealth>();
            health.CharacterToMonitor = character;
        }

        [TestCase(10)]
        public void Raises_Event_On_Heal(int a)
        {
            var amount = -1;
            character.Healed += (sender, args) => { amount = args.Amount; };
            character.Heal(a); 

            //Debug.Log(health.Received());
            //Assert.AreEqual(10, amount);
        }
    }
}