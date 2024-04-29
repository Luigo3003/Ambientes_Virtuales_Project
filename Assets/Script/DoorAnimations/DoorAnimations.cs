using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorAnimations : MonoBehaviour
{
    [SerializeField] 
    private Animator DoorRAnimator;
    [SerializeField]
    private Animator DoorLAnimator;
    private bool DoorState = true;
   public void ActivateDoorAnimation()
    {
        if (DoorState) {
            DoorRAnimator.SetTrigger("OpenTriggerR");
            DoorLAnimator.SetTrigger("OpenTriggerL");
            DoorState = false;
        }
        else if (DoorState == false) {
            DoorRAnimator.SetTrigger("CloseTriggerR");
            DoorLAnimator.SetTrigger("CloseTriggerL");
            DoorState = true;
        }
    }
}
