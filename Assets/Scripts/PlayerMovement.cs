using UnityEngine;

namespace Bobthief.SimpleJoystick
{
    public class PlayerMovement : MonoBehaviour
    {
        public SimpleJoystick joystick;
        private CharacterController characterController;

        public float speed = 12f;
        public float gravity = -9.81f;
        public float jumpHeight = 3f;

        public Transform groundCheck;
        public float groundDistance = 0.4f;
        public LayerMask groundMask;

        private float inputX = 0, inputZ = 0;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            inputX = inputZ = 0;

            //x = Input.GetAxisRaw("Horizontal");
            //z = Input.GetAxisRaw("Vertical");

            if (inputX == 0) inputX = joystick.Horizontal;
            if (inputZ == 0) inputZ = joystick.Vertical;

            var move = transform.right * inputX + transform.forward * inputZ;
            characterController.Move(move * speed * Time.deltaTime);
        }

        private void OnDrawGizmos()
        {
            Vector3 start = transform.position;
            Vector3 end = transform.position + Vector3.down * groundDistance;

            Gizmos.color = Color.green;
            Gizmos.DrawLine(start, end);
        }
    }
}
