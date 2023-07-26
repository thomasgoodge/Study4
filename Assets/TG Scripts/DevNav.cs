using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevNav : MonoBehaviour
{

    private string sceneIndex;
    private string newSceneIndex;
    
   
      private void AdvanceLevel(string sceneIndex)
    {
       //Function that Loads the scene from the string given in the Unity Editor - needs to match level name exactly to function
       SceneManager.LoadScene(sceneIndex);
    }
    // Update is called once per frame
    void Update()
    {
   

    }




}
