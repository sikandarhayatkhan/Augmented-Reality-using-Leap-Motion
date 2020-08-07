using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class userinput : MonoBehaviour
{
    public InputField input_name;
    public InputField input_age;
    public InputField input_clas;
    public Text text_value;
    //public Dropdown lerning_type;

    public static string name;
    public static string age;
    public static string clas;
    int lerning_value;
    public void Start()
    {
        //lerning_type.onValueChanged.AddListener(delegate
        //{
        //    lerning_typevaluechanged(lerning_type);
        //});
        //name = PlayerPrefs.GetString("inputnamevalue");
        //input_name.text = name;
        //age = PlayerPrefs.GetString("inputagevalue");
        //input_age.text = age;
        //clas = PlayerPrefs.GetString("inputclassvalue");
        //input_clas.text = clas;
    }

    //public void lerning_typevaluechanged(Dropdown sender)
    //{
    //    lerning_value = sender.value;
    //    Debug.Log("select" + lerning_value);
    //}

    public void getinputvalue()
    {
        name = input_name.text;
        PlayerPrefs.SetString("inputnamevalue", name);
        age = input_age.text;
        PlayerPrefs.SetString("inputagevalue", age);
        clas = input_clas.text;
        PlayerPrefs.SetString("inputclassvalue", clas);
        if (name == "" || name == null)
        {
            text_value.text = "Please Enter Your Name*";
        }
        else if (age == "" || age == null)
        {
            text_value.text = "Please Enter Your Age*";
        }
        else if (clas == "" || clas == null)
        {
            text_value.text = "Please Enter Your Class*";
        }
        else
        {
            text_value.text = "";
            Application.LoadLevel("ExcerciseType");
        }
    }
}
