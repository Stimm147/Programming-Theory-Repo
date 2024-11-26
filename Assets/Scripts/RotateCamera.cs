using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            RotateObject(horizontalInput);
        }
    }

    private void RotateObject(float direction)
    {
        transform.Rotate(Vector3.up, direction * rotationSpeed * Time.deltaTime);
    }
}
