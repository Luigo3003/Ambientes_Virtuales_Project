using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class TeleportPortal : MonoBehaviour
{
    [SerializeField] private Transform PointToTeleport;
    [SerializeField] private Volume Volume;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = PointToTeleport.position;
            Volume.enabled = true;

        }
    }
}
