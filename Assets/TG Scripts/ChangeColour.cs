using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

    public Material keyMaterial; 
    public Color currentColor;
    public Color baseColour = new Color (1f, 1f, 1f, 50f);
    public Color amberColour = new Color (1f, 1f, 1f, 50f);
    public Color redColour = new Color (1f, 1f, 1f, 50f);

    public float speed = 1f;

    public GameObject HazardOnsetManagerScript;
    
   

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard == true) {
            {
                SetColourToAmber();
            }
        }
        
    }

    public void SetColourToAmber()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        

        while (currentColor != amberColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, amberColour, tick);

        }
    }

    public void SetColourToRed()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        

        while (currentColor != redColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, redColour, tick);
            
        }    
    }
    
    public void SetColourToBase()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        

        while (currentColor != baseColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, baseColour, tick);
            
        }    
    }




}
