using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class HandAnimatorManager : MonoBehaviour
{
    public InputActionProperty Fingers_ActionAnimator;
    public InputActionProperty Fist_ActionAnimator;
    public Animator HandAnimator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float TriggerValue = Fingers_ActionAnimator.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", TriggerValue);

        float gripValue = Fist_ActionAnimator.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", gripValue);

    }
}
