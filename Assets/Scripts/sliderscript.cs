
using UnityEngine;
using UnityEngine.UI;

public class sliderscript : MonoBehaviour
{

    public Slider slider;




    public float value;
    void Start(){
        if(PlayerPrefs.GetFloat("slidervalue") != 0){
            value = PlayerPrefs.GetFloat("slidervalue");
            slider.value = value;
        }
    }

    void Update(){
        value = slider.value;
        PlayerPrefs.SetFloat("slidervalue", value);
    }
}
