using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Speed of rotation, in degrees per second
    public float rotationSpeed = 90f;

    void Update()
    {
        // Rotate the object around its z-axis
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}
