using UnityEngine;

public class Missile : MonoBehaviour
{
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        // Randomizes missile rotation
        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360);
    }
}