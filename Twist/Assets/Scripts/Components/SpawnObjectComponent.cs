using UnityEngine;

namespace Assets.Scripts.Components
{
    public class SpawnObjectComponent : MonoBehaviour
    {
        [Header("Object")]
        public GameObject ball;
        public bool needToDestroy;

        private Vector3 _poinSpawn;

        [Space][Header("Time")]
        public float startTime;
        public float repeatTime;
        public float destoyTime;

        private void Awake()
        {
            _poinSpawn = gameObject.transform.position;
        }
        private void Start()
        {
            InvokeRepeating("OnSpawn", startTime, repeatTime);
        }
        public void OnSpawn()
        {
            var currentBall = Instantiate(ball, _poinSpawn, Quaternion.identity);
            if(needToDestroy) Destroy(currentBall, destoyTime);
        }

    }
}
