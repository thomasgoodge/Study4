using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardWarningAlert : MonoBehaviour
{
  
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    public bool played = false;
    public bool hazardStatus = false;

    public GameObject HazardOnsetManagerScript;



private void Start()

{
    
}

private void Update() 
{
    hazardStatus = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard;
    if (hazardStatus == true && played == false)
    {
        PlayWarning();
        played = true;
    }
    if (hazardStatus == false)
    {
        played = false;
    }
}


    void PlayWarning()
    {
        audioSource.PlayOneShot(clip, volume);
    }


}

