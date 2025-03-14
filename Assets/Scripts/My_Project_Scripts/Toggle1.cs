using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;

public class Toggle1 : MonoBehaviour
{
    Interactable Toggled;
    public static bool isT1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.ClearDeveloperConsole();
        Toggled = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        isT1 = Toggled.IsToggled;
    }
}
