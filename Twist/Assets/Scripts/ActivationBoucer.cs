using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class ActivationBoucer : MonoBehaviour
    {
        public Animator animator;
        public float force;
        public Rigidbody2D ballRd2D;


        private bool _isActive;
        [SerializeField] private UnityEvent<GameObject> _action;


        private void Update()
        {
            //if (Input.GetKey(KeyCode.Space))
            //{
            //    animator.SetBool("ActiveBouser", true);
            //    if(Input.GetKeyDown(KeyCode.Space))
            //    {
            //        _isActive = true;
            //        return;
            //    } 
            //}
            //else
            //{
            //    animator.SetBool("ActiveBouser", false);
            //    _isActive = false;
            //}

            if (Input.GetKey(KeyCode.Space))
            {
                animator.SetBool("ActiveBouser", true);
                if (Input.GetKeyDown(KeyCode.Space) && _isActive && ballRd2D.velocity.magnitude < force)
                {
                    ballRd2D.AddForce(Vector2.up * force, ForceMode2D.Impulse);
                    _action?.Invoke(gameObject);
                    return;
                }
            }
            else
            {
                animator.SetBool("ActiveBouser", false);
            }


        }

        //private void OnTriggerStay2D(Collider2D collision)
        //{
        //    if (collision.gameObject.CompareTag("Player") && Input.GetKey(KeyCode.Space))
        //    {
        //        if (_isActive && collision.attachedRigidbody.velocity.magnitude < force)
        //        {
        //            collision.attachedRigidbody.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        //        }
        //    }
        //}
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _isActive = true;
            }
            else
            {
                _isActive = false;
            }
        }

        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _isActive = true;
            }
            else
            {
                _isActive = false;
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                _isActive = false;
            }
        }


    }
}
