using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightsaberOpening : MonoBehaviour
{
    public GameObject saber;
    bool turnOn = false;


    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable _interact = GetComponent<XRGrabInteractable>();
        _interact.activated.AddListener(turnOnSaber);
    }

  public void turnOnSaber(ActivateEventArgs args) {
        turnOn = !turnOn;
        saber.SetActive(turnOn);
    }
}
