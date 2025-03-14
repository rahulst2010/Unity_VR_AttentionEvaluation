using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Button1 : MonoBehaviour
{

    public static int menuBut;
    public void onpress1()
    {
        
            string t1 = Toggle1.isT1 ? "On" : "Off";
            string t2 = Toggle2.isT2 ? "On" : "Off";
            string s = Math.Round(Slider.slv, 2).ToString();
            string but = "Press Button1";

            string a = ChangeInstruction.a;
            string b = ChangeInstruction.b;
            string c = ChangeInstruction.c;
            string d = ChangeInstruction.d;

            double errorRate = 0;
            string Menu = null;

            if (t1 != a) errorRate++;
            if (t2 != b) errorRate++;
            if (s != c) errorRate++;
            if (but != d) errorRate++;

            if (menuBut == 1) Menu = "Notification";
            if (menuBut == 2) Menu = "Directional Arrow";
            if (menuBut == 3) Menu = "Audio Induced Arrow";

            errorRate = Menu != null ? errorRate / 4 : 0;
            double responseTime = Responded.respTime;


            Responded.respTime = 0;
            MenuB1.f1 = false;
            MenuB2.f2 = false;
            MenuB3.f3 = false;

            Debug.Log("Type : " + Menu + " **** Response Time : " + responseTime + " **** Error Rate : " + errorRate);
        
    }
}
