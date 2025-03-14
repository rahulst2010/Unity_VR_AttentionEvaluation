using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;

    private void OnGUI()
    {
        GUI.Box(new Rect(70, 70, 70, 70), score.ToString());
    }
}
