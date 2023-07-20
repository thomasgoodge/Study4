using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HazardWarningAlert : MonoBehaviour
{
  
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    public bool played = false;
    public bool hazardStatus = false;
    public Image warningImage;

    public GameObject HazardOnsetManagerScript;



private void Start()

{
    //GameObject go = GameObject.Find("WarningCanvas");

    //warningImage= go.GetComponent<Image>();

    warningImage.enabled = false;
}

private void Update() 
{
    hazardStatus = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard;
    if (hazardStatus == true && played == false)
    {
        PlayWarning();
        ShowWarningImage();
        played = true;
    }
    if (hazardStatus == false)
    {
        played = false;
        HideWarningImage();
    }
}


    void PlayWarning()
    {
        audioSource.PlayOneShot(clip, volume);
    }

    void ShowWarningImage()
    {
        warningImage.enabled = true;
    }
    
    void HideWarningImage()
    {
        warningImage.enabled = false;
    }

}

