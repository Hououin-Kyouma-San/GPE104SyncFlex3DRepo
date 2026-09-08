using UnityEngine;

public class FlareMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform tf;
    public float flareForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();

        if (rb != null && tf != null)
        {
            rb.AddForce(tf.up * flareForce, ForceMode.Impulse);
        }
    }
    void Update()
    {
    }
}
