using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public Transform SpawnPointPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("Entro al player");
            other.transform.position = SpawnPointPlayer.position;
            GameManager.instance.Wave = 1;
            GameManager.instance.WaveActive = false;
            GetComponentInParent<Enemy>().KillEnemy();
        }
        
    }
}
