using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour
{
    public Transform targetPosition;
    public float speed = 10;

    void Update()
    {
    transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);        
    }

}
