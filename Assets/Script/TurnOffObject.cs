using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffObject : MonoBehaviour
{
    public GameObject GOTurnOff;
    private bool Activate = false;


    public void TurnOn() {
            GOTurnOff.SetActive(true);
        
    }
    public void TurnOff() {
        
            GOTurnOff.SetActive(false); 
        
    }
}
