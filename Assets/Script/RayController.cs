using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayController : MonoBehaviour {
    [SerializeField] GameObject LeftTeleportation;
    [SerializeField] GameObject RightTeleportation;

    [SerializeField] InputActionProperty LeftActivate;
    [SerializeField] InputActionProperty RightActivate;

    [SerializeField] InputActionProperty LeftCancel;
    [SerializeField] InputActionProperty RightCancel;
    void Update()
    {
        LeftTeleportation.SetActive(LeftCancel.action.ReadValue<float>() == 0 && LeftActivate.action.ReadValue<float>() > 0.1);
        RightTeleportation.SetActive(RightCancel.action.ReadValue<float>() == 0 && RightActivate.action.ReadValue<float>() > 0.1);
    }
}
