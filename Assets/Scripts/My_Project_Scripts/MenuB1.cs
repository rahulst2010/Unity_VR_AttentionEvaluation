using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuB1 : MonoBehaviour
{
    public GameObject n1;
    public GameObject n2;
    public GameObject n3;

    public static bool flag = false;

    public static bool f1 = false;

    public void Start()
    {
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
    }

    float elapsedTime;
    public void pressed1()
    {
        Button1.menuBut = 1;

        SceneUIHandler.timer = DateTime.Now;
        ChangeInstruction.a = "Off";
    ChangeInstruction.b = "On";
    ChangeInstruction.c = "0.56";
    ChangeInstruction.d = "Press Button1";

        ChangeInstruction.flag = true;

        n1.SetActive(true);
        n2.SetActive(true);
        n3.SetActive(true);

        elapsedTime = 0;
        f1 = true;
    }

    private void Update()
    {
        if (flag)
        {
            n1.SetActive(false);
            n2.SetActive(false);
            n3.SetActive(false);
            flag = false;
            elapsedTime = 0;
        }

        if(f1)
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 15)
        {
            flag = true;
            if(f1)
            UnityEngine.Debug.Log("Type : Notification" + " **** Action : Ignored");
            elapsedTime = 0;
        }
    }
}
