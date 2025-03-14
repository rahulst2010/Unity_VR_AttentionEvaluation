using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;


public class Slider : MonoBehaviour
{
    PinchSlider sl;
    public static float slv;

    // Start is called before the first frame update
    void Start()
    {
        sl = GetComponent<PinchSlider>();
    }

    // Update is called once per frame
    void Update()
    {
        slv = sl.SliderValue;
    }
}
