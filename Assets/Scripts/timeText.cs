using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class timeText : MonoBehaviour
{
    public Text text;
    public GameObject Player;
    public int seconds = 0;
    public int minutes = 0;
    public float Hp;
    public int NumberOfEnemies;
    public string text2;
    void Start(){
        StartCoroutine("count");
    }
    void Update()
    {
        NumberOfEnemies = GameObject.FindGameObjectsWithTag("Target").Length;

        if(seconds == 60){
            seconds = 0;
            minutes = minutes + 1;
        }

        PlayerPrefs.SetInt("seconds", seconds);
        PlayerPrefs.SetInt("minutes", minutes);

        text2 = minutes.ToString()+":"+ seconds.ToString();

        text.text = text2;

        Player = GameObject.Find("Player(Clone)");
        PlayerMotor playerMotor = Player.GetComponent<PlayerMotor>();
        Hp = playerMotor.health;
        if(Hp<=0){
            StopAllCoroutines();
        }
        if(NumberOfEnemies == 0){
            StopAllCoroutines();
        }

    }
    IEnumerator count(){
        
        while(true){
            yield return new WaitForSeconds(1);
            seconds = seconds + 1;
        }
        
    }
    
        
    

    
}
