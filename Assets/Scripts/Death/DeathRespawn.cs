using UnityEngine;

public class DeathRespawn : Death
{
    public Vector3 respawnLocation = new Vector3(0.0f, 3.0f, -20.0f);
    public override void Die()
    {
        gameObject.transform.position = Vector3.zero + respawnLocation;
        gameObject.transform.rotation = Quaternion.identity;
    }
}