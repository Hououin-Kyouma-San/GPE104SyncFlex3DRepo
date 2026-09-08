using UnityEngine;

public class Enemy : Death
{
    void Start()
    {
        if (GameManager.instance.enemies != null)
        {
            GameManager.instance.enemies.Add(this);
        }
    }
    public override void Die()
    {
        if (GameManager.instance.enemies != null)
        {
            GameManager.instance.enemies.Remove(this);
        }
        Destroy(gameObject);
    }
}