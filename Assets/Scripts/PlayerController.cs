using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float rotationSpeed = 50f;
    public float tiltAmount = 20f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);


        float rotationAngle = horizontalInput * rotationSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.identity;
        rotation.w = Mathf.Cos(rotationAngle * 0.5f);
        rotation.x = 0f;
        rotation.y = Mathf.Sin(rotationAngle * 0.5f);
        rotation.z = 0f;
        transform.rotation *= rotation;


        float tiltAngle = -horizontalInput * tiltAmount * Time.deltaTime;
        Quaternion tilt = Quaternion.identity;
        tilt.w = Mathf.Cos(tiltAngle * 0.5f);
        tilt.x = 0f;
        tilt.y = 0f;
        tilt.z = Mathf.Sin(tiltAngle * 0.5f);
        transform.rotation *= tilt;
    }
}

