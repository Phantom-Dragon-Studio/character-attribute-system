using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;
using Moq;
using System;

namespace Tests
{
    public class CharacterTests
    {
        Character character;

        [SetUp]
        public void TestsSetup()
        {
            character = new GameObject().AddComponent<Character>();
            Debug.Log(character);
        }

        [Test]
        public void Raises_Event_On_Heal()
        {
            bool wasCalled = false;
            character.Healed += (sender, args) => wasCalled = true;
            character.Heal(10);
            Assert.IsTrue(wasCalled);
        }
    }
}