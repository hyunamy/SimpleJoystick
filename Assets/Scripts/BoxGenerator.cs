using UnityEngine;

namespace Bobthief.SimpleJoystick
{
    [RequireComponent(typeof(BoxCollider))]
    public class BoxGenerator : MonoBehaviour
    {
        public Transform parent;
        public GameObject prefab;
        public int generateCount = 50;

        private BoxCollider boxCollider;

        private void Awake()
        {
            boxCollider = GetComponent<BoxCollider>();
        }

        void Start()
        {
            for (int i = 0; i < generateCount; i++)
            {
                var gameObj = Instantiate(prefab, parent);
                gameObj.transform.position = GetStartRandomPosition();
                gameObj.transform.rotation = Quaternion.Euler(GetRandomRotation());
            }
        }

        private Vector3 GetRandomRotation()
        {
            Vector3 rot;
            rot.x = Random.value * 360;
            rot.y = Random.value * 360;
            rot.z = Random.value * 360;
            return rot;
        }


        private Vector3 GetStartRandomPosition()
        {
            Vector3 halSize = boxCollider.size * 0.5f;

            Vector3 position = boxCollider.transform.position;
            position.x += Random.Range(-halSize.x, halSize.x);
            position.z += Random.Range(-halSize.z, halSize.z);
            position.y = 5;

            return position;
        }

    }
}
