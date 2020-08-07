using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class collisionurdu1 : MonoBehaviour
{
    //public GameObject fish_obj;
    //BoxCollider fish_box_col;
    //MeshRenderer fish_mesh;
    public static int score;

    public static string obj1;
    public static string obj2;
    public static string obj3;

    //public Text score_value;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        obj1 = SelectorUrdu1.obj1;
        obj2 = SelectorUrdu1.obj2;
        obj3 = SelectorUrdu1.obj3;
        Debug.Log("obj1urdu" + obj1);
        Debug.Log("obj2urdu" + obj2);
        Debug.Log("obj3urdu" + obj3);
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
        if (collision.transform.name == obj3)
        {
            //Debug.Log("yanha coll hoe hai haha" + collision.transform.name);
            //Debug.Log("yanha coll hoe hai sc" + score);
            GameObject obj = GameObject.Find(obj3);
            this.enabled = false;
            score = 10;
            Debug.Log("scoreurdu : " + score);
            //Destroy(obj);
            //score_value.text = "Score : " + score;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name == obj3)
        {
            Debug.Log("yanha exit " + collision.transform.name);
            score = 0;
            Debug.Log("yanha coll hoe haiex" + score);
            //score_value.text = "Score : " + score;
        }
    }
}
