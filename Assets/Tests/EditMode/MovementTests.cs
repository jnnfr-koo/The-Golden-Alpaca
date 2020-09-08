using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovementTests
    {
        // Tests the method to calculate the new Vector based on an inputed vector and the speed.
        [Test]
        public void Calculate_Vector_Dircetion_And_Speed()
        {
            float speed = 10.0f;
            Move movement = new Move(speed);

            Vector3 direction = new Vector3(1, 0, 0);

            Assert.AreEqual(new Vector3(10, 0, 0), movement.CalculateMovement(direction));
        }
    }
}
