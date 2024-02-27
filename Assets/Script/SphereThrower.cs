using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereThrower : MonoBehaviour
{
    public GameObject Sphere;
    public Transform SphereSpawn;
    public float speedProjectile;
    public float SpawnRatio = 0;
    void Update()
    {
        SpawnRatio ++;
        if (SpawnRatio > 200 )
        {
            GameObject bullet = Instantiate(Sphere,SphereSpawn.position, SphereSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = SphereSpawn.forward * speedProjectile;
            SpawnRatio = 0;
        }
        
    }
}
