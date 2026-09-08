using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int currentLives;
    public TextMeshProUGUI livesCounter;
    public void Respawn()
    {
        // Checks for health and a minimum of one life
        if (GetComponent<Health>().currentHealth <= 0 && currentLives >= 1)
        {
            // Resets health amount and UI after respawning
            GetComponent<Health>().SetHealth(GetComponent<Health>().maxHealth);
            GetComponent<Health>().UpdateFillAmount();

            // Subtracts one life after respawning
            currentLives = currentLives - 1;
        }

        // Activates if there are no health or lives
        else if (GetComponent<Health>().currentHealth <= 0 && currentLives <= 0)
        {
            // Disables the gameObject containing the component
            gameObject.SetActive(false);
            //SceneManager.LoadScene("GameOverScreen");
            //Time.timeScale = 1.0f;
        }
    }

    public void UpdateLives()
    {
        if (livesCounter != null)
        {
            livesCounter.text = "" + currentLives;
        }
    }

    void Update()
    {
        UpdateLives();
    }
}