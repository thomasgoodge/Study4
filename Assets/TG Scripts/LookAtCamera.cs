using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{

    public Transform targetCamera;
  
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetCamera);
    }
}
