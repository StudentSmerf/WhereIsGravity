
using UnityEngine;
using UnityEngine.UI;

public class HpText : MonoBehaviour
{
    public Text text;
    public Text loseText;
    public Text hp1;
    public Text ammo1;
    public Text ammo2;
    public Text esc;
    public GameObject Player;
    public float Hp;
    public string HpString;

    void Update()
    {
        if(GameObject.Find("Player(Clone)").activeSelf == true){
            Player = GameObject.Find("Player(Clone)");
            PlayerMotor playerMotor = Player.GetComponent<PlayerMotor>();
            Hp = playerMotor.health;

            HpString = Hp.ToString();

            text.text = HpString;

            if(Hp <= 0){
                loseText.enabled = true;
                esc.enabled = true;
                
                hp1.enabled = false;
                text.enabled = false;
                ammo1.enabled = false;
                ammo2.enabled = false;
            }
        }

        
    }
}
