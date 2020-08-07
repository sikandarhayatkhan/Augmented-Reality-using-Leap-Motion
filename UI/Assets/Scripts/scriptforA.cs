using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scriptforA : MonoBehaviour
{
    public Text timetext;
    private float timeRemaining = 60;
    private bool timerIsRunning = false;
    public static string temp;
    public static int completetime;
    public Toggle mcq1;
    public Toggle mcq2;
    public Toggle mcq3;

    bool mcq1val;
    bool mcq2val;
    bool mcq3val;

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);
        timerIsRunning = true;
        score = 0;
        mcq1.isOn = false;
        mcq2.isOn = false;
        mcq3.isOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                //Debug.Log(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    //public void timervalue()
    //{
    //    int h = (int)timeRemaining;
    //    int completetime = 180 - h;
    //    float minutes = Mathf.FloorToInt(completetime / 60);
    //    float seconds = Mathf.FloorToInt(completetime % 60);
    //    temp = string.Format("{0:00}:{1:00}", minutes, seconds);
    //    Debug.Log("hhdcvbhgsdvcghsdvg" + h);
    //    Debug.Log("hhdcvbhgsdvcghsdvg" + temp);
    //    //Application.LoadLevel("Result");
        
    //}


    public void togglechange(bool change)
    {
        Debug.Log("change" + change);
        mcq2val = change;
    }
    public void togglevalue()
    {
        if(mcq2val == true)
        {
            score = score + 10;
            Debug.Log("score" + score);
        }
        else
        {
            score = score;
            Debug.Log("score" + score);
        }
        int h = (int)timeRemaining;
        completetime = 60 - h;
        float minutes = Mathf.FloorToInt(completetime / 60);
        float seconds = Mathf.FloorToInt(completetime % 60);
        temp = string.Format("{0:00}:{1:00}", minutes, seconds);
        Debug.Log("hhdcvbhgsdvcghsdvg" + h);
        Debug.Log("hhdcvbhgsdvcghsdvg" + temp);
        Application.LoadLevel("ObjectReB");
    }
}
