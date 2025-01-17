using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{
    public class KineticScultpure : MonoBehaviour
    {
        float angleRange = 45;
        float rotationDuration = 2f;

        void Start()
        {
            Transform parent = GameObject.Find("Boxes").transform;
            float delayTime = 0;
            foreach (Transform child in parent)
            {
                StartCoroutine(RotateSomething(child, delayTime));
                delayTime += 0.03f;
            }
        }

        IEnumerator RotateSomething(Transform something, float delay)
        {
            yield return new WaitForSeconds(delay);
            float startTime = Time.time;
            float elapsedTime = 0;

            while (elapsedTime < rotationDuration)
            {
                elapsedTime = Time.time - startTime;
                float rotationAngle = Mathf.PingPong(elapsedTime * 45, angleRange) - (angleRange / 2);
                something.rotation = Quaternion.Euler(0, rotationAngle, 0);
                yield return null;
            }
        }
    }
}
