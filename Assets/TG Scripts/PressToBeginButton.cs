using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToBeginButton : MonoBehaviour
{

    public void Start()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public void DisableRender()
    {
            //renderer.enabled = true; //(to show the game object)

            GetComponent<Renderer>().enabled = false; //(to hide the game object)
            //GetComponent<BoxCollider>().enabled = false;
            
    }

    public void EnableRender()
    {
            //renderer.enabled = true; //(to show the game object)

            GetComponent<Renderer>().enabled = true; //(to hide the game object)
            //GetComponent<BoxCollider>().enabled = true;


    }

    public void EnableObject()
    {
            //renderer.enabled = true; //(to show the game object)

                    gameObject.SetActive(true);


    }
}
