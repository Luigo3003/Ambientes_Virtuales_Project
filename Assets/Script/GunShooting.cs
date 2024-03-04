using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GunShooting : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] Transform TransBulletSpawn;
    [SerializeField] float speed = 5f;
    void Start()
    {
        XRGrabInteractable _interact = GetComponent<XRGrabInteractable>();
        _interact.activated.AddListener(FireGun);
    }

 public void FireGun(ActivateEventArgs args) {
        GameObject tempBullet = Instantiate(bullet, TransBulletSpawn.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody>().velocity = TransBulletSpawn.forward * speed;
        Destroy(tempBullet, 5f);

    }
}
