using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeInstruction : MonoBehaviour
{
    public static string a = "On";
    public static string b = "Off";
    public static string c = "0.40";
    public static string d = "Press Button1";
    public static bool flag = false;

    // Start is called before the first frame update
    public void Update()
    {
        if (flag)
        {
            GetComponent<TMP_Text>().SetText("Toggle 1 -> " + a + "\nToggle 2 -> " + b + "\nSet Slider -> " + c + "\n" + d);
            flag = false;
        }
    }

}
