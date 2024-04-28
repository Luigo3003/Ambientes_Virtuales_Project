using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnShip : MonoBehaviour
{
    public Transform originTransform;
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Ship"))
    //    {
    //        other.transform.position = originTransform.position;
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        print("colisio");
        if (collision.gameObject.CompareTag("Ship")) {
        
        collision.transform.position = originTransform.position;
        }
    }
}
