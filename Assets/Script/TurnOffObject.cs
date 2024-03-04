using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffObject : MonoBehaviour
{
    public GameObject GOTurnOff;


    public void TurnOn() {
            GOTurnOff.SetActive(true);
        
    }
    public void TurnOff() {
        
            GOTurnOff.SetActive(false); 
        
    }
}
