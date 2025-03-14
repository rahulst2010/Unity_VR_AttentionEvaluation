using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;

public class Toggle2 : MonoBehaviour
{
    Interactable Toggled;
    public static bool isT2;

    // Start is called before the first frame update
    void Start()
    {
        Toggled = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        isT2 = Toggled.IsToggled;
    }
}
