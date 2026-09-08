using System.Collections;
using UnityEngine;

public class FlareShooter : Shooter
{
    public GameObject flare;
    public Transform flareSpawnPointA;
    public Transform flareSpawnPointB;
    public override void Start()
    {
    }
    public override void Update()
    {
    }
    public override void Shoot()
    {
    }
    public override void Flare()
    {
        if (flare != null && flareSpawnPointA != null && flareSpawnPointB != null)
        {
            Instantiate(flare, flareSpawnPointA.position, flareSpawnPointA.rotation);
            Instantiate(flare, flareSpawnPointB.position, flareSpawnPointB.rotation);
        }
    }
}