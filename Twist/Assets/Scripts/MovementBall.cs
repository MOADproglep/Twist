using UnityEngine;

namespace Assets.Scripts
{
    public class MovementBall : MonoBehaviour
    {
        private Rigidbody2D _rd2D;
        private void Awake()
        {
            _rd2D = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            //transform.position += Vector3.forward * Time.deltaTime;

            _rd2D.AddForce(transform.right, ForceMode2D.Force);
            Debug.Log(transform.right);
        }
    }
}
