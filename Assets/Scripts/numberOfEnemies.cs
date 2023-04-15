
using UnityEngine;
using UnityEngine.UI;


public class numberOfEnemies : MonoBehaviour
{
    public int NumberOfEnemies;
    public Text NumberOfEnemiestext;
    public Text hp1;
    public Text hp2;
    public Text ammo1;
    public Text ammo2;
    public Text win;
    public Text esc;
    public string winstr;
    void Update()
    {
        NumberOfEnemies = GameObject.FindGameObjectsWithTag("Target").Length;
        NumberOfEnemiestext.text = NumberOfEnemies.ToString();
        if(NumberOfEnemies == 0){
            hp1.enabled = false;
            hp2.enabled = false;
            ammo1.enabled = false;
            ammo2.enabled = false;
            win.enabled = true;
            esc.enabled = true;
            winstr = "win";
        }
        if(NumberOfEnemies != 0){
            winstr = "lose";
        }

        PlayerPrefs.SetString("win", winstr);
    }
}
