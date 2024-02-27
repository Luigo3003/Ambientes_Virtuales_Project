using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    public GameObject _CanonBall;
    public Transform _CanonMouth;
    public Rigidbody _RBCB;
    public float speed;
    void Start()
    {
        _RBCB = _CanonBall.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    public void CanonExplosion() {

       GameObject CanonBallActive = Instantiate(_CanonBall, _CanonMouth.transform.position, Quaternion.identity);
        CanonBallActive.GetComponent<Rigidbody>().velocity = speed * Vector3.forward;

    }

    //public void DeleteObject() {
    //    gameObject.SetActive = false;
    //}
}
