using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // The speed at which the object will spin
    public float spinSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its local y-axis
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
