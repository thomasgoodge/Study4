using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RNG : MonoBehaviour
{

    public string numCode = "07";

    public int randomNum;
    public string numberPrompt;

    public Text displayText;
    // Start is called before the first frame update
    void Start()
    {
        generateRNG();
       // print(numCode + randomNum.ToString());

    }

    void Update()
    {
        numberPrompt = numCode + randomNum.ToString();
        displayText.text = "Number to call: " + numberPrompt;
    }


    void generateRNG()
    {
        randomNum = Random.Range(0, 999999999);

    }

}
