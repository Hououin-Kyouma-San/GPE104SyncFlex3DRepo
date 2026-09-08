using System.Collections;
using UnityEngine;

public class BulletShooter : Shooter
{
    public GameObject bullet;
    public Transform bulletSpawnPointA;
    public Transform bulletSpawnPointB;
    private float fireDelay = 0.075f;
    public override void Start()
    {
        
    }
    public override void Update()
    {
        
    }
    public override void Flare()
    {
    }
    public override void Shoot()
    {
        if (bullet != null && bulletSpawnPointA != null && bulletSpawnPointB != null)
        {
            // Creates coroutine controlling burst fire rate
            StartCoroutine(timer());
            IEnumerator timer()
            {
                if (bullet != null && bulletSpawnPointA != null && bulletSpawnPointB != null)
                {
                    Instantiate(bullet, bulletSpawnPointA.position, bulletSpawnPointA.rotation);
                    Instantiate(bullet, bulletSpawnPointB.position, bulletSpawnPointB.rotation);
                    // Sets timed delay after first shot and fires
                    yield return new WaitForSeconds(fireDelay);
                    Instantiate(bullet, bulletSpawnPointA.position, bulletSpawnPointA.rotation);
                    Instantiate(bullet, bulletSpawnPointB.position, bulletSpawnPointB.rotation);
                    // Sets timed delay after second shot and fires
                    yield return new WaitForSeconds(fireDelay);
                    Instantiate(bullet, bulletSpawnPointA.position, bulletSpawnPointA.rotation);
                    Instantiate(bullet, bulletSpawnPointB.position, bulletSpawnPointB.rotation);
                }
            }
        }
    }
}