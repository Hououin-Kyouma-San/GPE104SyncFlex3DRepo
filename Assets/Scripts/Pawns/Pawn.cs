using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    public float thrustForce;
    public float yawSpeed;
    public float rollSpeed;
    public float pitchSpeed;
    public abstract void Start();
    public abstract void Update();

    // Thrust methods
    public abstract void ThrustForward();
    public abstract void ThrustReverse();

    // Yaw methods
    public abstract void YawPort();
    public abstract void YawStarboard();

    // Roll methods
    public abstract void RollPort();
    public abstract void RollStarboard();

    // Pitch methods
    public abstract void PitchUp();
    public abstract void PitchDown();

    // Shoot method
    public abstract void Shoot();
    public abstract void Flare();
}
