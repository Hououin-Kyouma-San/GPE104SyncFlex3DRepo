using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public float damageValue;
    public float despawnTime;
    public bool destroyOnImpact;
    void Start()
    {
        Destroy(gameObject, despawnTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (destroyOnImpact)
        {
            Destroy(gameObject);
        }
    }
}