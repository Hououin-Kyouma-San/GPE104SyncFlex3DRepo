using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public SpaceShipPawn playerPawn;
    public List<Enemy> enemies;
    private void Awake()
    {
        enemies = new List<Enemy>();

        if (instance == null)
        {
            instance = this;

            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPawn != null && playerPawn.isActiveAndEnabled == false)
        {
            Debug.Log("Failure");

            // Create timer coroutine
            StartCoroutine(timer());
            IEnumerator timer()
            {
                // Set timer delay
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene("GameOverScreen");
                Time.timeScale = 1.0f;
            }
        }
        else if (playerPawn != null && enemies.Count == 0)
        {
            Debug.Log("Victory");
            SceneManager.LoadScene("VictoryScreen");
            Time.timeScale = 1.0f;
        }
    }
}