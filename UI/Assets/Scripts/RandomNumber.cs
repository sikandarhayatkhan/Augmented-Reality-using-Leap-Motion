using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RandomNumber : MonoBehaviour
{
    public Text timetext;
    private float timeRemaining = 180;
    private bool timerIsRunning = false;
    public static string temp;
    public static int timeforiq;
    public static int random_number;
    public Text number_text;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);
        timerIsRunning = true;
        //Random rand = new Random();
        random_number = Random.Range(1, 6);
        Debug.Log("heh "+ random_number);
        number_text.text = random_number.ToString();
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

    public void timervalue()
    {
        int h = (int)timeRemaining;
        int completetime = 180 - h;
        timeforiq = completetime;
        float minutes = Mathf.FloorToInt(completetime / 60);
        float seconds = Mathf.FloorToInt(completetime % 60);
        temp = string.Format("{0:00}:{1:00}", minutes, seconds);
        Debug.Log("hhdcvbhgsdvcghsdvg" + h);
        Debug.Log("hhdcvbhgsdvcghsdvg" + temp);
        Application.LoadLevel("Result");
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.name);
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.age);
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.clas);
    }

}
