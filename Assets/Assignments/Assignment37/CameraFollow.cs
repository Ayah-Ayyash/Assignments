using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment37
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target; // الهدف (الـ Sphere)
        private Vector3 difference; // الفرق بين موقع الكاميرا والهدف
        public bool LookAt = true; // إذا الكاميرا لازم تواجه الهدف
        public float cameraSpeed = 0.05f; // سرعة تحرك الكاميرا

        void Start()
        {
            // حساب الفرق بين موقع الكاميرا والهدف في البداية
            difference = transform.position - target.position;
            Debug.Log(difference);
        }

        void LateUpdate()
        {
            // تحريك الكاميرا بسلاسة نحو الهدف
            Vector3 newPosition = Vector3.Slerp(transform.position, target.position + difference, cameraSpeed);
            transform.position = newPosition;

            // إذا LookAt = true، الكاميرا رح تواجه الهدف
            if (LookAt)
            {
                transform.LookAt(target);
            }
        }
    }
}