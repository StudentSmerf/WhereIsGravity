
using UnityEngine;
using UnityEngine.UI;
public class numberButton : MonoBehaviour
{
    public Text text;
    public float value2;
    void Update()
    {
        
        
        value2 = PlayerPrefs.GetFloat("HpSlider");

        text.text = value2.ToString();
        
    }
}
