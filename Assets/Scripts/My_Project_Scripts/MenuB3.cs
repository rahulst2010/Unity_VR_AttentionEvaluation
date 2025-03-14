using System;
using System.Collections.Generic;
using UnityEngine;

public class MenuB3 : MonoBehaviour
{
    public static bool f3 = false;
    public void pressed3()
    {
        Button1.menuBut = 3;
        SceneUIHandler.timer = DateTime.Now;

        ChangeInstruction.a = "On";
        ChangeInstruction.b = "Off";
        ChangeInstruction.c = "0.93";
        ChangeInstruction.d = "Press Button2";

        ChangeInstruction.flag = true;

        f3 = true;
    }
}
