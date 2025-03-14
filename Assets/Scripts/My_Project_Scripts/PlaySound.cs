using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource aud;
    public static bool p2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pl)
        {
            if (elapsedTime == 0 || (elapsedTime > 2 && elapsedTime < 3) || (elapsedTime > 4 && elapsedTime < 5) || (elapsedTime > 6 && elapsedTime < 7) || (elapsedTime > 8 && elapsedTime < 9) || (elapsedTime > 10 && elapsedTime < 11) || (elapsedTime > 12 && elapsedTime < 13))
            { aud.Play(); elapsedTime++;  }
            elapsedTime += Time.deltaTime;
            if (elapsedTime > 12)
            {
                pl = false;
            }
        }
    }

    float elapsedTime;
    bool pl = false;

    public void playSoundEffect()
    {
        p2 = true;
        pl = true;
        elapsedTime = 0;
    }
}
