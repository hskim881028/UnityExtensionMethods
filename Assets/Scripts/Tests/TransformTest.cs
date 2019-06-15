using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.TestTools.Utils;

namespace Tests {
    public class TransformTest {

        [UnityTest]
        public IEnumerator TransformTestWithEnumeratorPasses() {
            // ordinary
            GameObject ordinaryObject = new GameObject("ordinary");
            Transform ordinaryTransform = ordinaryObject.transform;
            Vector3 position = new Vector3(100, ordinaryTransform.position.y, ordinaryTransform.position.z);
            ordinaryTransform.position = position;

            Vector3 scale = new Vector3(99, ordinaryTransform.position.y, ordinaryTransform.position.z);
            ordinaryTransform.localScale = scale;

            // extension method            
            GameObject newObject = new GameObject("extensionMethod");
            Transform newTransform = newObject.transform;
            newTransform.SetPositionX(100)
                        .SetLocalScaleX(99);
            // or      
            // newTransform.SetPositionX(100);
            // newTransform.SetLocalScaleX(99);
            yield return new WaitForFixedUpdate();
            float error = 10e-5f;

            // other 
            

            // compares two floating point numbers for equality under the given tolerance
            Assert.That(Utils.AreFloatsEqualAbsoluteError(ordinaryTransform.position.x, 
                                                          newTransform.position.x, 
                                                          error), Is.True);

            Assert.That(Utils.AreFloatsEqualAbsoluteError(ordinaryTransform.localScale.x, 
                                                          newTransform.localScale.x, 
                                                          error), Is.True);

            yield return null;
        }
    }
}
