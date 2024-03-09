using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform player;

    
    void Update()
    {
        agent.SetDestination(player.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("KillVolume"))
        {
            KillEnemy();
        }
    }

    public void KillEnemy()
    {
        GameManager.instance.EnemiesAlive--;
        print("Enemies left " + GameManager.instance.EnemiesAlive);
        Destroy(gameObject);
    }
}
