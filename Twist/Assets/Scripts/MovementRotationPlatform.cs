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

        private void FixedUpdate()
        {
            if (!onloopMovement)
            {
                rotationVector = Input.GetAxis("Horizontal");
                //float delta = rotationVector * speedRotation * Time.deltaTime;
                float delta = Mathf.SmoothDamp(rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
                transform.Rotate(0, 0, delta);
            }
            else
            {
                float delta = Mathf.SmoothDamp(loopSpeedRotation, 0f, ref zVelocity, 0.3f);
                transform.Rotate(0, 0, delta);
            }
            
        }
    }

}
 
