using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerMovementTests
    {
        [UnityTest]
        public IEnumerator Movement_Along_X_Axis_For_Horizontal_Input()
        {
            GameObject toAddPlayer = new GameObject();
            var player = toAddPlayer.AddComponent<Player>();

            yield return null;
        }
    }
}
