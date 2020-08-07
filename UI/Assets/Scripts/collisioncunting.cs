using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisioncunting : MonoBehaviour
{
    public static int count;
    public static int count1;
    public static int count2;
    public static int count3;
    public static int count4;
    public static int count5;
    public static int count6;
    public static int count7;
    public static int count8;
    int rad_num;
    // Start is called before the first frame update
    void Start()
    {
        rad_num = RandomNumber.random_number;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.name == "Sphere")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere");
            this.enabled = false;
            count = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere1")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere1");
            this.enabled = false;
            count1 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere2")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere2");
            this.enabled = false;
            count2 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere3")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere3");
            this.enabled = false;
            count3 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere4")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere4");
            this.enabled = false;
            count4 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere5")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere");
            this.enabled = false;
            count5 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere6")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere6");
            this.enabled = false;
            count6 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere7")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere7");
            this.enabled = false;
            count7 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere8")
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find("Sphere8");
            this.enabled = false;
            count8 = 1;
            //Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name == "Sphere")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere1")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count1 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere2")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count2 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere3")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count3 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere4")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count4 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere5")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count5 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere6")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count6 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere7")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count7 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
        if (collision.transform.name == "Sphere8")
        {
            Debug.Log("yanha exit " + collision.transform.name);
            count8 = 0;
            //Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
    }

}
