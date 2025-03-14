using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public void onpress2()
    {
        string t1 = Toggle1.isT1 ? "On" : "Off";
        string t2 = Toggle2.isT2 ? "On" : "Off";
        string s = Math.Round(Slider.slv, 2).ToString();
        string but = "Press Button2";

        string a = ChangeInstruction.a;
        string b = ChangeInstruction.b;
        string c = ChangeInstruction.c;
        string d = ChangeInstruction.d;

        double errorRate = 0;

        if (t1 != a) errorRate++;
        if (t2 != b) errorRate++;
        if (s != c) errorRate++;
        if (but != d) errorRate++;

        double responseTime = Responded.respTime;
        Responded.respTime = 0;
        MenuB1.f1 = false;
        MenuB2.f2 = false;
        MenuB3.f3 = false;
        string Menu = null;

        if (Button1.menuBut == 1) Menu = "Notification";
        if (Button1.menuBut == 2) Menu = "Directional Arrow";
        if (Button1.menuBut == 3) Menu = "Audio Induced Arrow";
        errorRate = Menu != null ? errorRate / 4 : 0;

        Debug.Log("Type : " + Menu + " **** Response Time : " + responseTime + " **** Error Rate : " + errorRate);
    }
}
