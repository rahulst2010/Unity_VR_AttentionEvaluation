using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob2 : MonoBehaviour
{
    float elapsedTime;
    float a = 0;
    public Color startColor;

    public void Start()
    {
        startColor = GetComponent<Renderer>().material.color;
    }

    public void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= a - 0.5 && elapsedTime <= a + 0.5)
        {
            if (GetComponent<Renderer>().material.color == Color.yellow)
            {
                Score.score -= 5;
                GetComponent<Renderer>().material.SetColor("_BaseColor", startColor);
            }
        }

        if ((elapsedTime >= 6 && elapsedTime <= 7) || (elapsedTime >= 14 && elapsedTime <= 15) || (elapsedTime >= 27 && elapsedTime <= 28) || (elapsedTime >= 34 && elapsedTime <= 35))
        {
            // insert logic for changing color below:
            GetComponent<Renderer>().material.SetColor("_BaseColor", Color.yellow);
            elapsedTime++;

            a = elapsedTime + 3;

        }
        if (elapsedTime > 40)
            elapsedTime = 0;
    }

    public void OnMouseDown()
    {
        if (GetComponent<Renderer>().material.color == Color.yellow)
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
