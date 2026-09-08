using UnityEngine;

public class SpaceShipPawn : Pawn
{
    private Rigidbody rb;
    private Transform tf;
    private Shooter shoot;
    public override void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        shoot = GetComponent<Shooter>();
    }
    public override void Update()
    {
    }

    // Thrust methods
    public override void ThrustForward()
    {
        if (rb != null)
        {
            rb.AddForce(tf.forward * Time.deltaTime * (thrustForce * 100.0f), ForceMode.Acceleration);
        }
    }
    public override void ThrustReverse()
    {
        if (rb != null)
        {
            rb.AddForce(tf.forward * Time.deltaTime * (-thrustForce * 100.0f), ForceMode.Acceleration);
        }
    }

    // Yaw methods
    public override void YawPort()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.up * Time.deltaTime * -yawSpeed);
        }
    }
    public override void YawStarboard()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.up * Time.deltaTime * yawSpeed);
        }
    }

    // Roll methods
    public override void RollPort()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.forward * Time.deltaTime * rollSpeed);
        }
    }
    public override void RollStarboard()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.forward * Time.deltaTime * -rollSpeed);
        }
    }

    // Pitch methods
    public override void PitchUp()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.left * Time.deltaTime * pitchSpeed);
        }
    }
    public override void PitchDown()
    {
        if (tf != null)
        {
            tf.Rotate(Vector3.left * Time.deltaTime * -pitchSpeed);
        }
    }

    // Shoot method
    public override void Shoot()
    {
        if (shoot != null)
        {
            shoot.Shoot();
        }
    }
}