using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuB2 : MonoBehaviour
{
    public static bool f2 = false;
    public void pressed2()
    {
        Button1.menuBut = 2;
        SceneUIHandler.timer = DateTime.Now;

        ChangeInstruction.a = "Off";
        ChangeInstruction.b = "Off";
        ChangeInstruction.c = "0.78";
        ChangeInstruction.d = "Press Button1";

        ChangeInstruction.flag = true;

        f2 = true;
    }
}
