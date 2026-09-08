using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damageAmount;
    public float damageDelay;
    public bool instantKill;
    public bool destroyOnImpact;

    private void OnCollisionEnter(Collision collision)
    {
        Health health = collision.gameObject.GetComponent<Health>();
        Pawn spaceship = collision.gameObject.GetComponent<Pawn>();

        // Checks if health exists and if starship exists
        if (health != null && spaceship != null)
        {
            // Creates timer coroutine
            StartCoroutine(timer());
            IEnumerator timer()
            {
                yield return new WaitForSeconds(damageDelay);

                // Checks if health and spaceship exists
                if (health != null && spaceship != null)
                {
                    health.TakeDamage(damageAmount);
                }
                // Checks if destroyOnImpact is true
                if (destroyOnImpact)
                {
                    Destroy(gameObject);
                }
            }
        }
        // Checks if health exists and if spaceship doesn't
        if (health != null && spaceship == null)
        {
            // Creates timer coroutine
            StartCoroutine(timer());
            IEnumerator timer()
            {
                yield return new WaitForSeconds(damageDelay);

                // Checks if health exists and if starship doesn't
                if (health != null && spaceship == null)
                {
                    health.TakeDamage(damageAmount);
                }
                // Checks if destroyOnImpact is true
                if (destroyOnImpact)
                {
                    Destroy(gameObject);
                }
            }
        }
        // Checks if instantKill is true
        if (instantKill)
        {
            // Creates timer coroutine
            StartCoroutine(timer());
            IEnumerator timer()
            {
                yield return new WaitForSeconds(damageDelay);

                // Checks if health or starship exists
                if (health != null || spaceship != null)
                {
                    health.TakeDamage(health.currentHealth);
                }
                // Checks if destroyOnImpact is true
                if (destroyOnImpact)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}