using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePortal : MonoBehaviour
{
    [SerializeField]
    private Animator PortalAnimator;
    [SerializeField]
    private Collider PortalCollider;
    private bool PortalState = false;
    public void PortalActivation()
    {
        if (PortalState == false)
        {
            PortalAnimator.SetTrigger("PortalActive");
            PortalCollider.enabled = true;
            PortalState = true;
        }
       else if (PortalState == true)
        {
            PortalAnimator.SetTrigger("PortalDeactive");
            PortalCollider.enabled = false;
            PortalState = false;

        }

    }
}
