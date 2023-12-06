using UnityEngine;

public class AnimatePrimitive : MonoBehaviour
{
    // Rotation support
    public float MaxDegree = 90f; // Max rotation in degrees
    public float DeltaDegree = 45f; // Rotation speed in degrees per second
    private float degree = 0f; // Current rotation degree
    private bool reversing = false; // Flag to control the direction of rotation

    public Vector3 rotAxis = Vector3.up;

    void Start()
    {
        // Initialize the rotation degree if necessary
    }

    void Update()
    {
        // Rotate back and forth between -MaxDegree and MaxDegree on the Y-axis
        if (!reversing)
        {
            degree += DeltaDegree * Time.deltaTime;
            if (degree >= MaxDegree)
            {
                degree = MaxDegree; // Clamp to the max degree to avoid overshooting
                reversing = true;   // Change direction
            }
        }
        else
        {
            degree -= DeltaDegree * Time.deltaTime;
            if (degree <= -MaxDegree)
            {
                degree = -MaxDegree; // Clamp to the min degree to avoid overshooting
                reversing = false;    // Change direction
            }
        }
        
        // Apply the rotation around the Y-axis
        transform.localRotation = Quaternion.AngleAxis(degree, rotAxis);
    }
}

