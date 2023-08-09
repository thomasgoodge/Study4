using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindScreenLocation : MonoBehaviour
{
    private Vector3 cubeLocation; 

    public GameObject ScreenCalibrationCube;
    // Start is called before the first frame update
    void Start()
    {
        ScreenCalibrationCube = GameObject.Find("ScreenCalibrationCube");
        if (ScreenCalibrationCube != null)
        {
            transform.position = ScreenCalibrationCube.transform.position;
        }
        else
        {
            transform.position = transform.position;
        }
    }

    
}
