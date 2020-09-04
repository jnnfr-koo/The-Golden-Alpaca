using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class HealthUnitTest
    {
        float maxHealth = 3.0f;
        float currentHealth = 0.0f;

        [Test]
        public void InstantializeHearts()
        {
            GameObject heart = null;
            Assert.IsNotNull(heart);
        }

        [Test]
        public void InitializeCurrentHealthToMaxHealth()
        {
            Assert.AreEqual(currentHealth, maxHealth);
        }

        [Test]
        public void IncreaseHealthByOne()
        {
            float oldHealth = 0.0f; 
            Assert.Greater(currentHealth, oldHealth);
        }

        [Test]
        public void DecreaseHealthByOne()
        {
            float oldHealth = 0.0f;
            Assert.Less(currentHealth, oldHealth);
        }
    }
}
