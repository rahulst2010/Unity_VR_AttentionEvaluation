using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responded : MonoBehaviour
{
    public void onRespond()
    {
        if (MenuB1.f1 || MenuB2.f2 || MenuB3.f3)
        {
            var elapsed = DateTime.Now - SceneUIHandler.timer;
            setResp(elapsed.Seconds);
            MenuB1.flag = true;

            MenuB1.f1 = false;
            MenuB2.f2 = false;
            MenuB3.f3 = false;
        }
    }

    public static double respTime = 0;
    public static void setResp(double el)
    {
        respTime = el;
    }
}
