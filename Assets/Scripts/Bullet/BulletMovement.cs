using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform tf;
    public float bulletForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();

        if (rb != null && tf != null)
        {
            rb.AddForce(tf.forward * bulletForce, ForceMode.Impulse);
        }
    }
    void Update()
    {
    }
}
