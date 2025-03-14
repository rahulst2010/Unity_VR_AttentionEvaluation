using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using UnityEngine;

public class SceneUIHandler : MonoBehaviour
{
    public GameObject go;

    public void Start()
    {
        go.SetActive(false);
        c = Color.green;
        go.GetComponent<Renderer>().material.SetColor("_Color", c);
    }

    public static DateTime timer;

    public void ToggleObject()
    {
        go.SetActive(true);
        pl = true;
        elapsedTime = 0;
     }

    DateTime a;

    void Update()
    {
        if (pl && go.activeSelf)
        {
            go.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 15)
            {
                pl = false;
                go.SetActive(false);
                if(MenuB2.f2)
                UnityEngine.Debug.Log("Type : Directional Solver" + " **** Action : Ignored");
                elapsedTime = 0;
            }
        }

        if(PlaySound.p2)
        {
            { 
                go.SetActive(true); 
                go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                c = c == Color.green ? Color.red : Color.green;
            }

            elapsedTime += Time.deltaTime;
            if (elapsedTime > 12)
            {
                PlaySound.p2 = false;
                go.SetActive(false);
                if(MenuB3.f3)
                UnityEngine.Debug.Log("Type : Audio Induced Solver" + " **** Action : Ignored");
                c = Color.green;
                elapsedTime = 0;
            }
        }
    }

    public void up(bool a)
    {
        if (a)
        {
            go.SetActive(!go.activeSelf); go.GetComponent<Renderer>().material.SetColor("_BaseColor", c);
            c = c == Color.green ? Color.red : Color.green;
        }

        else
        {
            go.SetActive(false);
            c = Color.green;
        }
    }

    float elapsedTime;
    bool pl = false;
    Color c;
}
