using UnityEngine;

namespace Bobthief.SimpleJoystick
{
    public class Box : MonoBehaviour
    {
        void Update()
        {
            float y = transform.position.y;
            if (y < -10)
            {
                Destroy(gameObject);
            }
        }
    }
}
