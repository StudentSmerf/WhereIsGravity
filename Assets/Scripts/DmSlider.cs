using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DmSlider : MonoBehaviour
{
    public Slider slider;
    public float value;
    
    void Start(){
        if(PlayerPrefs.GetFloat("DmSlider") != 0){
        value = PlayerPrefs.GetFloat("DmSlider");
        slider.value = value;
        }
    }

    void Update(){
        value = slider.value;
        PlayerPrefs.SetFloat("DmSlider", value);
    }
}
