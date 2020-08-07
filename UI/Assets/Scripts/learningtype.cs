using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class learningtype : MonoBehaviour
{
    public Dropdown learning_type;
    public int learningvalue;
    public void Start()
    {
        learning_type.onValueChanged.AddListener(delegate
        {
            learningtypevaluechanged(learning_type);
        });
        
    }

    public void learningtypevaluechanged(Dropdown sender)
    {
        learningvalue = sender.value;
        Debug.Log("Your select" + sender.value);
    }

    public void loadscene()
    {
        if (learningvalue == 1)
        {
            Application.LoadLevel("StartScreen");
        }
        if (learningvalue == 2)
        {
            Application.LoadLevel("StartScreen");
        }
    }
}
