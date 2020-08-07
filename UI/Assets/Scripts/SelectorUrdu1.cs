using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArabicSupport;
using UnityEngine.SceneManagement;
public class SelectorUrdu1 : MonoBehaviour
{
    public Text timetext;
    private float timeRemaining = 180;
    private bool timerIsRunning = false;

    public static string temp;
    public static int timeforiq;

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

    public static string obj1;
    public static string obj2;
    public static string obj3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);

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
                obj1 = text_value;
                PlayerPrefs.SetString("object11name", obj1);
                string[] split_obj_name = text_value.Split(new char[] { '_' });
                //Debug.Log("hehe1" + split_obj_name[0]);
                text.text = split_obj_name[0];
                if (text.text == "duck")
                {
                    text.text = ArabicFixer.Fix("بطخ");
                   
                }
                if (text.text == "apple")
                {
                    text.text = ArabicFixer.Fix("سیب");
                    
                }
                if (text.text == "cone")
                {
                    text.text = ArabicFixer.Fix("آئس کریم");
                }
                if (text.text == "ball")
                {
                    text.text = ArabicFixer.Fix("گیند");
                }
                if (text.text == "cat")
                {
                    text.text = ArabicFixer.Fix("بلی");
                }
                if (text.text == "fish")
                {
                    text.text = ArabicFixer.Fix("مچھلی");
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
                    obj2 = "";
                    PlayerPrefs.SetString("object22name", obj2);
                }
                else
                {
                    obj2 = text1_value;
                    PlayerPrefs.SetString("object22name", obj2);
                    split_obj_name = text1_value.Split(new char[] { '_' });
                    //Debug.Log("hehe2" + split_obj_name[0]);
                    text1.text = split_obj_name[0];
                    if (text1.text == "duck")
                    {
                        text1.text = ArabicFixer.Fix("بطخ");
                    }
                    if (text1.text == "apple")
                    {
                        text1.text = ArabicFixer.Fix("سیب");
                    }
                    if (text1.text == "cone")
                    {
                        text1.text = ArabicFixer.Fix("آئس کریم");
                    }
                    if (text1.text == "ball")
                    {
                        text1.text = ArabicFixer.Fix("گیند");
                    }
                    if (text1.text == "cat")
                    {
                        text1.text = ArabicFixer.Fix("بلی");
                    }
                    if (text1.text == "fish")
                    {
                        text1.text = ArabicFixer.Fix("مچھلی");
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
                    obj3 = "";
                    PlayerPrefs.SetString("object33name", obj3);
                }
                else
                {
                    obj3 = text2_value;
                    PlayerPrefs.SetString("object33name", obj3);
                    split_obj_name = text2_value.Split(new char[] { '_' });
                    //Debug.Log("hehe3" + split_obj_name[0]);
                    text2.text = split_obj_name[0];
                    if (text2.text == "duck")
                    {
                        text2.text = ArabicFixer.Fix("بطخ");
                    }
                    if (text2.text == "apple")
                    {
                        text2.text = ArabicFixer.Fix("سیب");
                    }
                    if (text2.text == "cone")
                    {
                        text2.text = ArabicFixer.Fix("آئس کریم");
                    }
                    if (text2.text == "ball")
                    {
                        text2.text = ArabicFixer.Fix("گیند");
                    }
                    if (text2.text == "cat")
                    {
                        text2.text = ArabicFixer.Fix("بلی");
                    }
                    if (text2.text == "fish")
                    {
                        text2.text = ArabicFixer.Fix("مچھلی");
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
