using System;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Color startColor;

    public void Start()
    {
        startColor = GetComponent<Renderer>().material.color;
    }

    public void OnMouseDown()
    {
        if (GetComponent<Renderer>().material.color == Color.white)
        {
            Score.score += 5;
        }

        else
        {
            Score.score -= 5;
        }

        GetComponent<Renderer>().material.SetColor("_BaseColor", startColor);
    }
}
