using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

using UnityEngine;
using UnityEngine.UI;


public class CorrectNumberChecker : MonoBehaviour
{
    public string targetNumber;
    public string userNumber;
    public int score = 0;

    public string newNumber;

    public Text dialText;
    public StringBuilder sb = new StringBuilder();

    public string numCode = "07";
    public int randomNum;

    public Text displayText;
    public Text scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
      generateRNG();

    }

    // Update is called once per frame
    void Update()
    {       
        userNumber = sb.ToString();
        dialText.text = userNumber;
        scoreText.text = "Numbers dialled: " + score.ToString();

        
        
    }

    public void checkNumber()
    {
        if (userNumber == targetNumber)
        {
            score++;

           generateRNG();
           sb.Clear();
        }
        else
        {
            return;
        }
    }

    void generateRNG()
    {
        randomNum = Random.Range(111111111, 999999999);
        targetNumber = numCode + randomNum.ToString();
        displayText.text = "Number to call: " + targetNumber;


    }
    
    public void WriteString()
    {

        string path = Application.persistentDataPath + "/" + "numbersDialled.txt";

        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine(scoreText.text);
   
        writer.Close();

    }

    public void dialOne(string numberInput)
    {
        newNumber = "1";
       // print(newNumber);
        sb.Append(newNumber);
    }
     public void dialTwo(string numberInput)
    {
         newNumber = "2";
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialThree(string numberInput)
    {
         newNumber = "3";
    //print(newNumber);
    sb.Append(newNumber);
     }
    public void dialFour(string numberInput)
    {
         newNumber = "4";
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialFive(string numberInput)
    {
         newNumber = "5";
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialSix(string numberInput)
    {
         newNumber = "6";
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialSeven(string numberInput)
    {
         newNumber = "7";
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialEight(string numberInput)
    {
         newNumber = "8";
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialNine(string numberInput)
    {
         newNumber = "9";
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialZero(string numberInput)
    {
         newNumber = "0";
    //print(newNumber);
    sb.Append(newNumber);
    }

    public void dialStar(string numberInput)
    {
         newNumber = "*";
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialHash(string numberInput)
    {
         newNumber = "#";
   // print(newNumber);
    sb.Append(newNumber);
    }

    public void deleteLastNumber(string numberInput)
    {
        if (sb.Length > 0)
        {
        //numberInput.Substring(0, numberInput.Length-1);
        sb.Remove(sb.Length - 1, 1);
        }
    }


}
