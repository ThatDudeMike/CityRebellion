using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraControlSystem
{
    public class CameraControls : MonoBehaviour
    {
        [SerializeField]
        private float panSpeed = .5f;

        [SerializeField]
        private float rotateSpeed = .5f;

        // Update is called once per frame
        void Update()
        {
            CheckForwardMovement();
            CheckRightMovement();
            CheckRotate();
        }

        private void CheckForwardMovement()
        {
            Vector3 forwardWithSpeed = transform.forward * panSpeed;

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                gameObject.transform.Translate(forwardWithSpeed, Space.World);
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                gameObject.transform.Translate(-forwardWithSpeed, Space.World);
            }
        }
        private void CheckRightMovement()
        {
            Vector3 rightWithSpeed = transform.right * panSpeed;

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(rightWithSpeed, Space.World);
            }
            else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(-rightWithSpeed, Space.World);
            }
        }

        private void CheckRotate()
        {
            Quaternion rot = gameObject.transform.rotation;

            if (Input.GetKey(KeyCode.E))
            {
                gameObject.transform.Rotate(Vector3.up, rotateSpeed, Space.World);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                gameObject.transform.Rotate(Vector3.up, -rotateSpeed, Space.World);
            }
        }
    }
}
