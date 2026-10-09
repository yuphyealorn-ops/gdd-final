using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // spin the propeller around its Z axis every frame
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
