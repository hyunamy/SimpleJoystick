using UnityEngine;

namespace Bobthief.SimpleJoystick
{
    public class CameraLook : MonoBehaviour
    {
        public SimpleJoystick joystick;

        public Vector2 sensitivity = new Vector2(100, 100);
        public Transform playerBody;

        private float xRotation = 0;

        void Update()
        {
            float camX = joystick.Horizontal * sensitivity.x * Time.deltaTime;
            float camY = joystick.Vertical * sensitivity.y * Time.deltaTime;

            xRotation -= camY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);

            transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            playerBody.Rotate(Vector3.up * camX);
        }
    }
}