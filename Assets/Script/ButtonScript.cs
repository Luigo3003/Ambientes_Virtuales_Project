using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class ButtonScript : MonoBehaviour
{
    XRSlider sliderRef;
    public GameObject GOInstantiate;
    public Transform InstantiatePos;
    private void Start() {
      sliderRef = GetComponent<XRSlider>();
    }
    private void Update() {
        

        //if (sliderRef.value <= 0.5) {
        //    print("Slider off");
        //}
        //else if (sliderRef.value >= 0 - 5) {
        //    print("Slider on");
        //}
    }
    public void MovX() {

        print("Movimiento en X");
    }

    public void MovY() {

        print("Movimiento en Y");
    }

    public void printSomethingButton() {

        print("Button Pressed");
     }

    public void printSomethingValue() {

        print("Value Changed");
    }

    public void InstantiateObject() {
        Instantiate(GOInstantiate, InstantiatePos.position, Quaternion.identity);


    }
}
