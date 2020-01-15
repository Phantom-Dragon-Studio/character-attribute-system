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
        Character character;
        Health health;
        Character.HealedEventArgs ag;

        [SetUp]
        public void CharacterTestsSimplePasses()
        {
            character = new Character();
            health = new Health(-1, character);
            character.Health.Returns(health);

            ag = new Character.HealedEventArgs(10);
        }

        [TestCase(10)]
        public void Raises_Event_On_Heal(int a)
        {
            var amount = -1;
            character.Healed += (sender, args) => { amount = args.Amount; };
            Assert.AreEqual(character.Health.CurrentHealth, amount);
        }
    }
}