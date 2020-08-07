using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Selector :  MonoBehaviour
{
    //public GameObject trash_bin;
    //public GameObject trash_bin1;
    //public GameObject trash_bin2;
    public Text timetext;
    private float timeRemaining = 180;
    private bool timerIsRunning = false;
    public static string temp;
    public static int timeforiq;

    protected GameObject gameobj1;
    protected GameObject gameobj2;
    protected GameObject gameobj3;
    
    public Text text;
    public Text text1;
    public Text text2;
    
    string text_value;
    string text1_value;
    string text2_value;

    public GameObject position1;
    public GameObject position2;
    public GameObject position3;

    string obj1;
    string obj2;
    string obj3;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("SceneNumber", SceneManager.GetActiveScene().name);
        //Debug.Log("age"+userinput.age);
        timerIsRunning = true;

        //trash_bin.GetComponent<MeshCollider>();
        string[] names = new string[] { "duck_obj","apple_obj","cone_obj","ball_obj","cat_obj","fish_obj" };
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
                string[] split_obj_name = text_value.Split(new char[] {'_'});
                //Debug.Log("hehe1"+split_obj_name[0]);
                text.text = split_obj_name[0];
                obj1 = text_value;
                PlayerPrefs.SetString("obj1name", obj1);
                text.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
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
                    PlayerPrefs.SetString("obj2name", obj2);
                }
                else
                {
                    obj2 = text1_value;
                    PlayerPrefs.SetString("obj2name", obj2);
                    split_obj_name = text1_value.Split(new char[] { '_' });
                    //Debug.Log("hehe2" + split_obj_name[0]);
                    text1.text = split_obj_name[0];
                    text1.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
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
                    PlayerPrefs.SetString("obj3name", obj3);
                }
                else
                {
                    obj3 = text2_value;
                    PlayerPrefs.SetString("obj3name", obj3);
                    split_obj_name = text2_value.Split(new char[] { '_' });
                    //Debug.Log("hehe3" + split_obj_name[0]);
                    text2.text = split_obj_name[0];
                    text2.text = char.ToUpper(split_obj_name[0][0]) + split_obj_name[0].Substring(1);
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
                //Debug.Log("Time has run out!");
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
        //Debug.Log("hhdcvbhgsdvcghsdvg" + h);
        //Debug.Log("hhdcvbhgsdvcghsdvg" + temp);
        Application.LoadLevel("Result");
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.name);
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.age);
        //Debug.Log("hhdcvbhgsdvcghsdvg" + u.clas);
    }

    //private void OnCollisionEnter(Collision collision)
    //{

    //    if (collision.gameObject.name == gameobj1.name)
    //    {
    //        Debug.Log("Game" + gameobj1.name);
    //    }
    //    //else if (collision.gameObject.name == gameobj2.name)
    //    //{
    //    //    Debug.Log("Game1" + gameobj2.name);
    //    //}
    //    //else if (collision.gameObject.name == gameobj1.name)
    //    //{
    //    //    Debug.Log("Game2" + gameobj3.name);
    //    //}
    //    //else
    //    //    Debug.Log("Gamsabjhasbe");
    //}
}
