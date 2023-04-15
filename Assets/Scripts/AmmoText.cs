using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    public Text text;
    public Text NoAmmotext;
    public GameObject Player;
    public int Ammo;
    public string AmmoString;

    void Update()
    {
        if(GameObject.Find("Player(Clone)").activeSelf == true){
            Player = GameObject.Find("Player(Clone)");
            PlayerMotor playerMotor = Player.GetComponent<PlayerMotor>();
            Ammo = playerMotor.Ammo;

            AmmoString = Ammo.ToString();

            text.text = AmmoString;

            if(Ammo == 0){
                NoAmmotext.enabled = true;
            }
            if(Ammo != 0){
                NoAmmotext.enabled = false;
            }
        }
    }
}
