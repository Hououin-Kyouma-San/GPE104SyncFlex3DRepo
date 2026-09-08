using UnityEngine;

public class BulletShooter : Shooter
{
    public GameObject bullet;
    public Transform bulletSpawnPoint;
    public override void Start()
    {
        
    }
    public override void Update()
    {
        
    }
    public override void Shoot()
    {
        if (bullet != null && bulletSpawnPoint != null)
        {
            Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        }
    }
}