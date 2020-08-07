using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class dropdownvalue : MonoBehaviour
{
    public Dropdown excercise;
    public Dropdown language;
    public Dropdown learning_type;
    
    public int excercise_value;
    public int language_value;
    public int learning_value;
    
    public void Start()
    {
        excercise.onValueChanged.AddListener(delegate
        {
            excercisevaluechanged(excercise);
        });
       
        language.onValueChanged.AddListener(delegate
        {
            languagevaluechange(language);
        });

        learning_type.onValueChanged.AddListener(delegate
        {
            learningtypevaluechanged(learning_type);
        });
    }

    public void excercisevaluechanged(Dropdown sender)
    {
        excercise_value = sender.value;
        Debug.Log("Your select" + excercise_value);
    }
    
    public void languagevaluechange(Dropdown sender)
    {
        language_value = sender.value;
        Debug.Log("Your select" + language_value);
    }

    public void learningtypevaluechanged(Dropdown sender)
    {
        learning_value = sender.value;
        Debug.Log("Your select" + sender.value);
    }
    public void loadscene()
    {
        if (excercise_value == 0 && language_value == 0 && learning_value == 0)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 0 && language_value == 0 && learning_value == 1)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 0 && language_value == 1 && learning_value == 0)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 0 && language_value == 1 && learning_value == 1)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 1 && language_value == 0 && learning_value == 0)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 1 && language_value == 0 && learning_value == 1)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 1 && language_value == 1 && learning_value == 0)
        {
            Application.LoadLevel("ExcerciseType");
        }
        if (excercise_value == 1 && language_value == 1 && learning_value == 1)
        {
            Application.LoadLevel("ObjectMathing");
        }
        if (excercise_value == 1 && language_value == 1 && learning_value == 2)
        {
            Application.LoadLevel("ObjectMathingPrac");
        }
        if (excercise_value == 1 && language_value == 2 && learning_value == 1)
        {
            Application.LoadLevel("ObjectMathingUrdu");
        }
        if (excercise_value == 1 && language_value == 2 && learning_value == 2)
        {
            Application.LoadLevel("ObjectMathingUrduPrac");
        }
        if (excercise_value == 2 && language_value == 1 && learning_value == 1)
        {
            Application.LoadLevel("Counting");
        }
        if (excercise_value == 2 && language_value == 1 && learning_value == 2)
        {
            Application.LoadLevel("CountingPrac");
        }
        if (excercise_value == 2 && language_value == 2 && learning_value == 1)
        {
            Application.LoadLevel("CountingUrdu");
        }
        if (excercise_value == 2 && language_value == 2 && learning_value == 2)
        {
            Application.LoadLevel("CountingUrduPrac");
        }
        if (excercise_value == 3 && language_value == 1 && learning_value == 1)
        {
            Application.LoadLevel("ObjectRe");
        }
        if (excercise_value == 3 && language_value == 1 && learning_value == 2)
        {
            Application.LoadLevel("ObjectRePrac");
        }
        if (excercise_value == 3 && language_value == 2 && learning_value == 1)
        {
            Application.LoadLevel("ObjectReUrdu");
        }
        if (excercise_value == 3 && language_value == 2 && learning_value == 2)
        {
            Application.LoadLevel("ObjectReUrduPrac");
        }
    }
       
    // Update is called once per frame
        void Update()
        {
        
        }  
    
}
