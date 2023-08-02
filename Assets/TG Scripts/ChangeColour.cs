using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{

    private Material keyMaterial; 
    public Color currentColor;
    public Color baseColour = new Color (1f, 1f, 1f, 80f);
    public Color amberColour = new Color (255f, 120f, 0f, 80f);
    public Color redColour = new Color (255f, 0f, 0f, 80f);

    public float speed = 0.05f;

    public GameObject HazardOnsetManagerScript;
    
   

    // Start is called before the first frame update
    void Start()
    {
        //access the material attached to this object
        keyMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("o"))
        {
        StartCoroutine(SetColourToAmber());
        }
        if (Input.GetKey("p"))
        {
        StartCoroutine(SetColourToRed());
        }
        if (Input.GetKey("i"))
        {
        StartCoroutine(SetColourToBase());
        }

        if (HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard == true) {
            {
                SetColourToAmber();
            }
        }
        
    }

    private IEnumerator SetColourToAmber()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        
        while (currentColor != amberColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, amberColour, tick);
            yield return null;

        }
    }

    private IEnumerator SetColourToRed()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        while (currentColor != redColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, redColour, tick);
            yield return null;
            
        }    
    }
    
    private IEnumerator SetColourToBase()
    {
        float tick = 0f;
        currentColor = keyMaterial.color;
        

        while (currentColor != baseColour)
        {
            tick += Time.deltaTime * speed;
            keyMaterial.color = Color.Lerp(currentColor, baseColour, tick);
            yield return null;
            
        }    
    }




}
