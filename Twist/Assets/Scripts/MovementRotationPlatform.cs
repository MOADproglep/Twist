using UnityEngine;

namespace Assets
{
    public class MovementRotationPlatform : MonoBehaviour
    {
        [Space][Header("Game mechanics")]
        public float speedRotation;
        public float zVelocity = 0.0f;

        private float _rotationVector;

        [Space][Header("Loop Movement")]
        public bool onloopMovement;
        public float loopSpeedRotation;


        private Rigidbody2D _rd2D;

        private void Awake()
        {
            _rd2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (!onloopMovement)
            {
                _rotationVector = Input.GetAxis("Horizontal") * speedRotation;
                if (_rotationVector != 0)
                {
                    //_rd2D.constraints = RigidbodyConstraints2D.FreezePosition;
                    //float delta = _rotationVector * speedRotation * Time.deltaTime;
                    //float delta = Mathf.SmoothDamp(_rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
                    //transform.Rotate(0, 0, delta);
                    _rd2D.angularVelocity = Mathf.SmoothDamp(_rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
                }
                //else _rd2D.constraints = RigidbodyConstraints2D.FreezeAll;
                
            }
            else
            {
                float delta = Mathf.SmoothDamp(loopSpeedRotation, 0f, ref zVelocity, 0.3f);
                transform.Rotate(0, 0, delta);
            }
            
        }
    }

}
 
