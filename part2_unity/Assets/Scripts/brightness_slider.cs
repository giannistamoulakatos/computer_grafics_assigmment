using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brightness_slider : MonoBehaviour
{   
    public Slider assigment_slider;
    public Light slider_light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider_light.intensity = assigment_slider.value;  
    }
}
