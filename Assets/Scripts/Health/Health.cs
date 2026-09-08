using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public Image healthBar;

    // Healing functions
    public float GetHealth()
    {
        return currentHealth;
    }

    public void SetHealth(float healthAmount)
    {
        currentHealth = healthAmount;
    }

    public void Heal(float amount)
    {
        // Gets currentHealth and adds an amount, returning new currentHealth value
        currentHealth += amount;

        // Gets currentHealth and prevents it from exceeding maxHealth
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateFillAmount();
    }

    // Damage functions
    public void TakeDamage(float amount)
    {
        // Gets currentHealth and subtracts an amount, returning new currentHealth value
        currentHealth -= amount;

        // Gets currentHealth and prevents it from falling below zero
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateFillAmount();

        // Checks if currentHealth is less than or equal to zero
        if (currentHealth <= 0)
        {
            // Die
            Death deathComponent = GetComponent<Death>();

            if (deathComponent != null)
            {
                // Activates death function
                deathComponent.Die();

                // Checks if there is no health and if Lives component exists
                if (currentHealth <= 0 && GetComponent<Lives>() != null)
                {
                    // Activates respawn function inside Lives component
                    GetComponent<Lives>().Respawn();
                }

                // Activates if there are no health or lives
                else if (currentHealth >= 0 && GetComponent<Lives>() == null)
                {
                    // Disables the gameObject containing the component
                    gameObject.SetActive(false);
                }
            }
        }
    }

    public void UpdateFillAmount()
    {
        if (healthBar != null)
        {
            healthBar.fillAmount = currentHealth / maxHealth;
        }
    }
}