using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{

private Vector3 keyLocation;
private Vector3 startLocation; 
private Vector3 addCoords = new Vector3 (0.1f, 0.1f, 0f);
private Vector3 newLocation;

public float smoothTime = 0.2f;
private Vector3 velocity = Vector3.zero;
public bool canStayHere = true;
public bool hazardActive = false;

public GameObject HazardOnsetManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position;
        print(this.ToString() + startLocation.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
       // hazardActive = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard;
        ChangeObjectPosition();
        if (hazardActive == false && canStayHere == true)
        {
            ReturnToPosition();
        }
          
    }
    void OnTriggerStay(Collider collision)
    {
        //Register collisions depending on the tags for the objects.
        //Play audio clip for each type of sphere. (AtPoint instead of OneShot because there are multiple different types of audio clips to play)
        if (collision.gameObject.tag == "Hazard" )//|| collision.collider.tag == "Button")
        {
            canStayHere = false;            
        }
 
      
    }
    private void OnTriggerExit(Collider collision) 
    {
        if (collision.gameObject.tag == "Hazard" || collision.gameObject.tag == "Button" )//|| collision.collider.tag == "Button")
        {
            canStayHere = true;            
        }
        
    }

    void ChangeObjectPosition()
    {
        if (canStayHere == false)
        {        
            newLocation = transform.position + addCoords;
            transform.position = Vector3.SmoothDamp(transform.position, newLocation, ref velocity, smoothTime);
        }
        else if (canStayHere == true)
        {
           transform.position = transform.position;
        }
        
    }   

    void ReturnToPosition()
    {
        transform.position = Vector3.SmoothDamp(transform.position, startLocation, ref velocity, smoothTime);
     
    }


}