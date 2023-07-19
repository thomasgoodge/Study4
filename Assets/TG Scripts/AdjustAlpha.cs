using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;


public class AdjustAlpha : MonoBehaviour
{
        // Start is called before the first frame update
   private Material currentMat;
   private float newAlpha;
   //private PinchSlider slider;

   void Start()
   {
    currentMat = gameObject.GetComponent<Renderer>().material;
   // slider = GameObject.Find("PinchSlider");
   }

    // Update is called once per frame
    void Update()
    {
       // newAlpha = slider.sliderValue;
        ModifyAlpha(newAlpha);
    }


    public void ModifyAlpha(float alphaVal)
    {
        Color oldColor = currentMat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        currentMat.SetColor("_Color", newColor);    
    }

}
