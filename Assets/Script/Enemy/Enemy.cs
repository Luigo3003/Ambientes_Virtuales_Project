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
}