using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    void Start()
    {
        
    }

    public float rotationSpeed = 50f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
