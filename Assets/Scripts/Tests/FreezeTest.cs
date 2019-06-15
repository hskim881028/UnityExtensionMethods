using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class FreezeTest {
        [UnityTest]
        public IEnumerator FreezeTestWithEnumeratorPasses() {
            // ordinary
            GameObject ordinaryObject = new GameObject("ordinary");
            Rigidbody ordinaryRigidbody = ordinaryObject.AddComponent<Rigidbody>();
            ordinaryRigidbody.velocity = Vector3.zero;
            ordinaryRigidbody.angularVelocity = Vector3.zero;
            ordinaryRigidbody.isKinematic = true;
            
            // extension method
            GameObject newObject = new GameObject("extensionMethod");
            Rigidbody newRigidbody = newObject.AddComponent<Rigidbody>();
            newRigidbody.Freeze();

            Assert.AreEqual(ordinaryRigidbody.velocity, newRigidbody.velocity);
            Assert.AreEqual(ordinaryRigidbody.isKinematic, newRigidbody.isKinematic);
            Assert.AreEqual(ordinaryRigidbody.angularVelocity, newRigidbody.angularVelocity);
            yield return null;
        }
    }
}
