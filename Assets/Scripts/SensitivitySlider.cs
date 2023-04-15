using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SensitivitySlider : MonoBehaviour
{
    
    public float SensValue = 1f;
    public Slider Slider;
    void Start(){
        Slider.value = PlayerPrefs.GetFloat("Sensitivity");
    }
    void Update()
    {
        SensValue = Slider.value;
        PlayerPrefs.SetFloat("Sensitivity", SensValue);
        
    }

}
