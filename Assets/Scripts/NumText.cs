using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NumText : MonoBehaviour
{
    public Text text;
    public float value2;
    void Update()
    {
        
        
        value2 = PlayerPrefs.GetFloat("slidervalue");

        text.text = value2.ToString();
        
    }
}
