using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OnClick : MonoBehaviour
{

    public void loadscene(string name)
    {
        Application.LoadLevel(name);
    }
    public void exitcene()
    {
        Debug.Log("quit");
        //EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
