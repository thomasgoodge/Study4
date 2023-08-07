using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDialpad : MonoBehaviour
{
    public GameObject Keypad;
    public GameObject HazardOnsetManagerScript;
    public bool showKeypad;
    

    // Start is called before the first frame update
    void Start()
    {
            showKeypad = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().stopwatchRunning;
            

    }

    // Update is called once per frame
    void Update()
    {
       
        showKeypad = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().stopwatchRunning;
        if (showKeypad == true)
        {
            Keypad.SetActive(true);
        }
        else if (showKeypad == false)
        {
            Keypad.SetActive(false);
        }

    }
}
