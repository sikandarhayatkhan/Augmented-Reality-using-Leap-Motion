using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;
public class Selectorurdu : MonoBehaviour
{

    public Text timetext;
    private float timeRemaining = 180;
    private bool timerIsRunning = false;

    GameObject gameobj1;
    GameObject gameobj2;
    GameObject gameobj3;

    public Text text;
    public Text text1;
    public Text text2;

    string text_value;
    string text1_value;
    string text2_value;

    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;

        string[] names = new string[] { "duck_obj", "apple_obj", "cone_obj", "ball_obj", "cat_obj", "fish_obj" };
        string[] obj_name = new string[] { "Duck", "Apple", "Ice-Cream", "Ball", "Cat", "Fish" };
        for (int i = 0; i < 3; i++)
        {
            int random_number = Random.Range(0, names.Length);
            int random_obj_names = Random.Range(0, obj_name.Length);
            if (i == 0)
            {
                gameobj1 = GameObject.Find(names[random_number]);
                //text_value = obj_name[random_obj_names];
                text_value = gameobj1.name;
                string[] split_obj_name = text_value.Split(new char[] { '_' });
                Debug.Log("hehe1" + split_obj_name[0]);
                text.text = split_obj_name[0];
                if (text.text == "duck")
                {
                    text.text = "بطخ";
                }
                if (text.text == "apple")
                {
                    text.text = "سیب";
                }
                if (text.text == "cone")
                {
                    text.text = "آئس کریم";
                }
                if (text.text == "ball")
                {
                    text.text = "گیند";
                }
                if (text.text == "cat")
                {
                    text.text = "بلی";
                }
                if (text.text == "fish")
                {
                    text.text = "مچھلی";
                }
                //text.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
                //GUILayout.TextField(text_value);
                //Debug.Log(gameobj1.name);
                //Debug.Log(text_value);
            }
            if (i == 1)
            {
                string[] split_obj_name;
                gameobj2 = GameObject.Find(names[random_number]);
                //text1_value = obj_name[random_obj_names];
                text1_value = gameobj2.name;
                if (text1_value == text_value || text1_value == text2_value)
                {
                    text1.text = "";
                }
                else
                {
                    split_obj_name = text1_value.Split(new char[] { '_' });
                    Debug.Log("hehe2" + split_obj_name[0]);
                    text1.text = split_obj_name[0];
                    if (text1.text == "duck")
                    {
                        text1.text = ArabicFixer.Fix("بطخ");
                    }
                    if (text1.text == "apple")
                    {
                        text1.text = "سیب";
                    }
                    if (text1.text == "cone")
                    {
                        text1.text = ArabicFixer.Fix("آئس کریم",false,false);
                    }
                    if (text1.text == "ball")
                    {
                        text1.text = "گیند";
                    }
                    if (text1.text == "cat")
                    {
                        text1.text = "بلی";
                    }
                    if (text1.text == "fish")
                    {
                        text1.text = "مچھلی";
                    }
                    //text1.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
                    //text1.text = text1_value;
                    //GUILayout.TextField(text1_value);
                    //Debug.Log(gameobj2.name);
                    //Debug.Log(text1_value);
                }
                //string[] split_obj_name = text1_value.Split(new char[] { '_' });
                //Debug.Log("hehe2" + split_obj_name[0]);
                //text1.text = split_obj_name[0];
                //text1.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
                //text1.text = text1_value;
                //GUILayout.TextField(text1_value);
                //Debug.Log(gameobj2.name);
                //Debug.Log(text1_value);
            }
            if (i == 2)
            {
                string[] split_obj_name;
                gameobj3 = GameObject.Find(names[random_number]);
                //text2_value = obj_name[random_obj_names];
                text2_value = gameobj3.name;
                if (text2_value == text_value || text2_value == text1_value)
                {
                    text2_value = "";
                }
                else
                {
                    split_obj_name = text2_value.Split(new char[] { '_' });
                    Debug.Log("hehe3" + split_obj_name[0]);
                    text2.text = split_obj_name[0];
                    if (text2.text == "duck")
                    {
                        text2.text = "بطخ";
                    }
                    if (text2.text == "apple")
                    {
                        text2.text = "سیب";
                    }
                    if (text2.text == "cone")
                    {
                        text2.text = "آئس کریم";
                    }
                    if (text2.text == "ball")
                    {
                        text2.text = "گیند";
                    }
                    if (text2.text == "cat")
                    {
                        text2.text = "بلی";
                    }
                    if (text2.text == "fish")
                    {
                        text2.text = "مچھلی";
                    }
                    //text2.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
                    //text2.text = text2_value;
                    //GUILayout.TextField(text2_value);
                    //Debug.Log(gameobj3.name);
                    //Debug.Log(text2_value);
                }
            }
        }
        gameobj1.transform.position = position1.transform.position;
        gameobj2.transform.position = position2.transform.position;
        gameobj3.transform.position = position3.transform.position;
    }

    //private void OnGUI()
    //{
    //    GUILayout.TextField(text_value);
    //    GUILayout.TextField(text1_value);
    //    GUILayout.TextField(text2_value);
    //}
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
}
