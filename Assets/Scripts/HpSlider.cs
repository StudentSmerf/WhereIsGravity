using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpSlider : MonoBehaviour
{
    public Slider slider;
    public float value;
    
    void Start(){
        if(PlayerPrefs.GetFloat("HpSlider") != 0){
        value = PlayerPrefs.GetFloat("HpSlider");
        slider.value = value;
        }
    }

    void Update(){
        value = slider.value;
        PlayerPrefs.SetFloat("HpSlider", value);
    }
}
