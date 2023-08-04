using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{

private Vector3 keyLocation;
private Vector3 startLocation; 

private Vector3 addXCoords = new Vector3 (0.1f, 0f, 0f);
private Vector3 addYCoords = new Vector3 (0f, 0.1f, 0f);
private Vector3 addDoubleXCoords = new Vector3 (0.15f, 0f, 0f);
private Vector3 addDoubleYCoords = new Vector3 (0f, 0.15f, 0f);

private Vector3 subtractCoords = new Vector3 (-0.1f, -0.1f, 0f);
private Vector3 newLocation;

public float smoothTime = 0.05f;
private Vector3 velocity = Vector3.zero;
public bool canStayHere = true;
public bool hazardActive = false;
public bool preHazardActive = false;

public GameObject HazardOnsetManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        startLocation = transform.position;
        //print(this.ToString() + startLocation.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        preHazardActive = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().preHazard;
        hazardActive = HazardOnsetManagerScript.GetComponent<HazardOnsetManager>().hazard;
        ChangeObjectPosition();
        if (hazardActive == false && preHazardActive == false)
        {
            canStayHere = true;
            ReturnToPosition();
        }
        
          
    }
    void OnTriggerStay(Collider collision)
    {
        //Register collisions depending on the tags for the objects.
        //Play audio clip for each type of sphere. (AtPoint instead of OneShot because there are multiple different types of audio clips to play)
        if (collision.gameObject.tag == "Hazard")//|| //collision.gameObject.tag == "Button")
        {
            canStayHere = false;            
        }
        if (collision.gameObject.tag == "Button")//|| //collision.gameObject.tag == "Button")
        {
            canStayHere = false;            
        }
    }
    private void OnTriggerExit(Collider collision) 
    {
        if (collision.gameObject.tag == "Hazard")// ||) collision.gameObject.tag == "Button" )
        {
            canStayHere = true;            
        }
        if (collision.gameObject.tag == "Button")// ||) collision.gameObject.tag == "Button" )
        {
            canStayHere = true;            
        }
        
    }

    void ChangeObjectPosition()
    {
        if (canStayHere == false)
        {  
            if (gameObject.name == "1Key"|| gameObject.name == "4Key" || gameObject.name == "7Key" || gameObject.name == "EnterKey")     
            { 
            newLocation = transform.position - addYCoords - addXCoords;
            transform.position = Vector3.SmoothDamp(transform.position, newLocation, ref velocity, smoothTime);
            }
            else if (gameObject.name == "2Key"|| gameObject.name == "5Key" || gameObject.name == "8Key" || gameObject.name == "0Key")     
            { 
            newLocation = transform.position + addYCoords + addXCoords;
            transform.position = Vector3.SmoothDamp(transform.position, newLocation, ref velocity, smoothTime);
            }
            else 
            {
            newLocation = transform.position + addDoubleYCoords + addDoubleXCoords;
            transform.position = Vector3.SmoothDamp(transform.position, newLocation, ref velocity, smoothTime);
            }
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