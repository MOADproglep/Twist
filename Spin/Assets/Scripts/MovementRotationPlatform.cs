using UnityEngine;

public class MovementRotationPlatform : MonoBehaviour
{
    private float rotationVector;
    public float speedRotation;

    private void FixedUpdate()
    {
        rotationVector = Input.GetAxis("Horizontal");
        float delta = rotationVector * speedRotation * Time.deltaTime;
        transform.Rotate(0, 0, delta);
    }
}
