using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CollosionDetectionandScore2 : MonoBehaviour
{
    //public GameObject fish_obj;
    //BoxCollider fish_box_col;
    //MeshRenderer fish_mesh;
    public static int score;

    string obj1;
    string obj2;
    string obj3;

    //public Text score_value;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        obj1 = CollosionDetectionandScore.obj1;//PlayerPrefs.GetString("obj1name");
        obj2 = CollosionDetectionandScore.obj2;//PlayerPrefs.GetString("obj2name");
        obj3 = CollosionDetectionandScore.obj3;//PlayerPrefs.GetString("obj3name");
        Debug.Log("obj111" + obj1);
        //Debug.Log("obj222" + obj2);
        //Debug.Log("obj333" + obj3);
        //fish_box_col = fish_obj.GetComponent<BoxCollider>();
        //fish_mesh = fish_obj.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //fish_mesh.material.color = Color.red;
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.name == obj1)
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find(obj1);
            this.enabled = false;
            score = 10;
            Debug.Log("score" + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name == obj1)
        {
            Debug.Log("yanha exit " + collision.transform.name);
            score = 0;
            Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
    }
}
