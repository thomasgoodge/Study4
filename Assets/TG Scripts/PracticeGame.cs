using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PracticeGame : MonoBehaviour
{

    public Text targetText;
    public string target;
    public string userResponse;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;


    string[] targetList = new string[] {"A","B","C", "D", "E", "F"};
     void Start() {
       resetTarget();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (userResponse == target)
        {
            PlayCorrect();
            resetTarget();
            userResponse = "";
            PracticeTrial();
          
            

        }
        
    }

public void PracticeTrial()
    {
       
        setTarget(); 
       
        

    }


    void setTarget()
    {
        target = targetList[Random.Range(0, targetList.Length)];
        targetText.text = target;

    }
    void resetTarget()
    {
        target = "";
        targetText.text = target;
    }
    
     public void pressAKey()
        {
            userResponse = "A";
        }

    public void pressBKey()
        {
            userResponse = "B";
        }
    public void pressCKey()
        {
            userResponse = "C";
        }
    public void pressDKey()
        {
            userResponse = "D";
        }
    public void pressEKey()
        {
            userResponse = "E";
        }
    public void pressFKey()
        {
            userResponse = "F";
        }
    void PlayCorrect()
    {
       
        audioSource.PlayOneShot(clip, volume);
        
    }

}




