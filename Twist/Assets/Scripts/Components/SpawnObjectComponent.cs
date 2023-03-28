using UnityEngine;

namespace Assets.Scripts.Components
{
    public class SpawnObjectComponent : MonoBehaviour
    {
        [Header("Object")]
        public GameObject ball;
        public bool needToDestroy;

        private Vector3 poinSpawn;

        [Space][Header("Time")]
        public float startTime;
        public float repeatTime;
        public float destoyTime;

        private void Awake()
        {
            poinSpawn = gameObject.transform.position;
        }
        private void Start()
        {
            InvokeRepeating("OnSpawn", startTime, repeatTime);
        }
        public void OnSpawn()
        {
            var currentBall = Instantiate(ball, poinSpawn, Quaternion.identity);
            if(needToDestroy) Destroy(currentBall, destoyTime);
        }

    }
}
