using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class CanonBall : MonoBehaviour
{
    public GameObject _CanonBall;
    public Transform _CanonMouth;
    public Rigidbody _RBCB;
    public float speed;
    XRSocketInteractor sx;


    void Start()
    {
        sx = GetComponent<XRSocketInteractor>();
        _RBCB = _CanonBall.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    public void CanonExplosion() {

        GameObject CanonBallActive = Instantiate(_CanonBall, _CanonMouth.transform.position, Quaternion.identity);
        CanonBallActive.GetComponent<Rigidbody>().velocity = speed * Vector3.forward;
        IXRSelectInteractable ObjectEnteringSocket = sx.GetOldestInteractableSelected();
        print(ObjectEnteringSocket);
        Destroy(ObjectEnteringSocket.transform.gameObject);
        
    }
}
