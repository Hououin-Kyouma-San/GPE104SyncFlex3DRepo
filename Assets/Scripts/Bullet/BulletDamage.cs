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
        Health health = collision.gameObject.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damageValue);
            if (destroyOnImpact)
            {
                Destroy(gameObject);
            }
        }
    }
}