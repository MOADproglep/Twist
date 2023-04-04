using UnityEngine;

namespace Assets.Scripts
{
    public class MovementBall : MonoBehaviour
    {
        private Rigidbody2D rd2D;
        private void Awake()
        {
            rd2D = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            //transform.position += Vector3.forward * Time.deltaTime;

            rd2D.AddForce(transform.right, ForceMode2D.Force);
            Debug.Log(transform.right);
        }
    }
}
