using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float lifeTime = 0;
    private float BulleTime = 0;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulleTime ++;
        if (BulleTime > lifeTime)
        {
            Destroy(bullet);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.CompareTag("Saber"))
        {
            Destroy(bullet);
            
        }
    }
}
