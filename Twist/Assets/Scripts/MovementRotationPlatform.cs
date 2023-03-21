using UnityEngine;

namespace Assets
{
    public class MovementRotationPlatform : MonoBehaviour
    {
        public float speedRotation;
        float zVelocity = 0.0f;
        private float rotationVector;

        private void FixedUpdate()
        {

            rotationVector = Input.GetAxis("Horizontal");
            //float delta = rotationVector * speedRotation * Time.deltaTime;
            float delta = Mathf.SmoothDamp(rotationVector * speedRotation, 0f, ref zVelocity, 0.3f);
            transform.Rotate(0, 0, delta);
        }
    }

}
 
