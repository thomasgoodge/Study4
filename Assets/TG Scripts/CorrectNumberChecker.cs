using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class CorrectNumberChecker : MonoBehaviour
{

    [SerializeField] public Stopwatch keypressCounter = new Stopwatch();
    List<long> keyTimes = new List<long>();
    public string targetNumber;
    public string userNumber;
    public int score = 0;
    public int keypresses = 0;
    public long keypressTrialTime;
    public bool keyStopwatchRunning = false;

    public string condition;

    public string newNumber;

    public Text dialText;
    public StringBuilder sb = new StringBuilder();

    public string numCode = "07";
    public int randomNum;

    public Text displayText;
    public Text scoreText;

    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;
    public string date;
    

    
    // Start is called before the first frame update
    void Start()
    {
      generateRNG();
      KeyStopwatchStart();
      condition = SceneManager.GetActiveScene().name;


    }

    // Update is called once per frame
    void Update()
    {       
        userNumber = sb.ToString();
        dialText.text = userNumber;
        scoreText.text = "Numbers dialled: " + score.ToString();
        keypressTrialTime = keypressCounter.ElapsedMilliseconds;
        WriteString();
        
    }

    public void CheckDate()
    {
        date = System.DateTime.UtcNow.ToString();
        print(date);
    }

    public void checkNumber()
    {
        if (userNumber == targetNumber)
        {
            score++;
            keyTimes.Add(keypressTrialTime);
            PlayCorrectAudio();
            generateRNG();
            sb.Clear();
            KeyStopwatchReset();
            KeyStopwatchStart();
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
        writer.WriteLine(date);
        writer.WriteLine(condition);
        writer.WriteLine(scoreText.text);        
        writer.WriteLine("Keypresses: " + keypresses);
        writer.WriteLine(keyTimes);        


        writer.Close();
    }

    public void dialKeyName(string numberInput)
    {
        newNumber = numberInput;
        keypresses++;

       // print(newNumber);
        sb.Append(newNumber);
    }
/*
public void dialOne(string numberInput)
    {
        newNumber = "1";
        keypresses++;

       // print(newNumber);
        sb.Append(newNumber);
    }
     public void dialTwo(string numberInput)
    {
         newNumber = "2";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialThree(string numberInput)
    {
         newNumber = "3";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
     }
    public void dialFour(string numberInput)
    {
         newNumber = "4";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialFive(string numberInput)
    {
         newNumber = "5";
         keypresses++;
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialSix(string numberInput)
    {
         newNumber = "6";
         keypresses++;
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialSeven(string numberInput)
    {
         newNumber = "7";
         keypresses++;
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialEight(string numberInput)
    {
         newNumber = "8";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialNine(string numberInput)
    {
         newNumber = "9";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
    }
    public void dialZero(string numberInput)
    {
         newNumber = "0";
         keypresses++;
    //print(newNumber);
    sb.Append(newNumber);
    }

    public void dialStar(string numberInput)
    {
         newNumber = "*";
         keypresses++;
   // print(newNumber);
    sb.Append(newNumber);
    }
    public void dialHash(string numberInput)
    {
         newNumber = "#";
         keypresses++;
   // print(newNumber);
    sb.Append(newNumber);
    }
*/
    public void deleteLastNumber(string numberInput)
    {
        if (sb.Length > 0)
        {
        //numberInput.Substring(0, numberInput.Length-1);
        keypresses++;
        sb.Remove(sb.Length - 1, 1);
        }
    }
    public void KeyStopwatchStart()
    {  //Function to start the stopwatch when the button is pressed
       keypressCounter.Start();
       keyStopwatchRunning = true;
    }

    public void KeyStopwatchReset()
    {
       keypressCounter.Stop();
       keypressCounter.Reset();
       keyStopwatchRunning = false;
    }
    void PlayCorrectAudio()
    {
       
        audioSource.PlayOneShot(clip, volume);
        
    }

}
