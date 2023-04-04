using UnityEngine;

namespace Assets
{
    public class MovementRotationPlatform : MonoBehaviour
    {
        [Space][Header("Game mechanics")]
        public float speedRotation;
        float zVelocity = 0.0f;
        private float rotationVector;

        [Space][Header("Loop Movement")]
        public bool onloopMovement;
        public float loopSpeedRotation;


        private Rigidbody2D rd2D;

        private void Awake()
        {
            rd2D = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            if (!onloopMovement)
            {
                rotationVector = Input.GetAxis("Horizontal") * speedRotation;
                if (rotationVector != 0)
                {
                    //rd2D.constraints = RigidbodyConstraints2D.FreezePosition;
                    //float delta = rotationVector * speedRotation * Time.deltaTime;
                    //float delta = Mathf.SmoothDamp(rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
                    //transform.Rotate(0, 0, delta);
                    rd2D.angularVelocity = Mathf.SmoothDamp(rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
                }
                //else rd2D.constraints = RigidbodyConstraints2D.FreezeAll;
                
            }
            else
            {
                float delta = Mathf.SmoothDamp(loopSpeedRotation, 0f, ref zVelocity, 0.3f);
                transform.Rotate(0, 0, delta);
            }
            
        }
    }

}
 
