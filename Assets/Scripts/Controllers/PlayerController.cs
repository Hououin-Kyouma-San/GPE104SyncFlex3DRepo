using UnityEngine;

public class PlayerController : Controller
{
    // Thrust keys
    public KeyCode thrustForward;
    public KeyCode thrustReverse;

    // Yaw rotation keys
    public KeyCode yawPort;
    public KeyCode yawStarboard;

    // Roll rotation keys
    public KeyCode rollPort;
    public KeyCode rollStarboard;

    // Pitch rotation keys
    public KeyCode pitchUp;
    public KeyCode pitchDown;

    public override void Start()
    {
    }
    public override void Update()
    {
        MakeDecisions();
    }
    public void MakeDecisions()
    {
        if (pawn != null)
        {
            // Thrust controls
            if (Input.GetKey(thrustForward))
            {
                pawn.ThrustForward();
            }
            if (Input.GetKey(thrustReverse))
            {
                pawn.ThrustReverse();
            }

            // Yaw controls
            if (Input.GetKey(yawPort))
            {
                pawn.YawPort();
            }
            if (Input.GetKey(yawStarboard))
            {
                pawn.YawStarboard();
            }

            // Roll controls
            if (Input.GetKey(rollPort))
            {
                pawn.RollPort();
            }
            if (Input.GetKey(rollStarboard))
            {
                pawn.RollStarboard();
            }

            // Pitch controls
            if (Input.GetKey(pitchUp))
            {
                pawn.PitchUp();
            }
            if (Input.GetKey(pitchDown))
            {
                pawn.PitchDown();
            }
        }
    }
}