using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Colision");
        GameObject TempGO = collision.gameObject;
        Debug.Log(TempGO, TempGO);
        if (TempGO.CompareTag("Enemy"))
        {
            TempGO.GetComponent<Enemy>().KillEnemy();
        }
    }
}
