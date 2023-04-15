
using UnityEngine;
using UnityEngine.UI;

public class boxRespawn : MonoBehaviour
{
    public GameObject Box;
    public GameObject Box2;
    public GameObject Box3;
    public GameObject Box4;
    public GameObject Target;
    public GameObject Player;
    public int i = 0;
    public int o = 0;
    public int p = 0;
    public int t = 0;
    public int x;
    public int y;
    public int z;
    public Text pauseText;
    private Vector3 BoxPosition;
    private Vector3 TargetPosition;
    private Vector3 PlayerPos = new Vector3(0, 1, 0);
    public int StartGame = 0;
    public int gameStarted = 0;

    public float enemiesNumber;
    public GameObject map;

    void StartGame1(){

        

        if(StartGame == 1){

            Instantiate(Player, PlayerPos, Quaternion.identity, map.transform);
            
            gameStarted = 1;

            
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            //Screen.lockCursor = true;

            x = Random.Range(-9, 9);
            y = Random.Range(-9, 9);
            z = Random.Range(-9, 9);

            BoxPosition = new Vector3(x, y, z);


            for(i = 0; i < 10; i++){
                Instantiate(Box, BoxPosition, Quaternion.identity, map.transform);
                x = Random.Range(-9, 9);
                y = Random.Range(-9, 9);
                z = Random.Range(-9, 9);
                BoxPosition = new Vector3(x, y, z);
            }
            for(o = 0; o < 10; o++){
                Instantiate(Box2, BoxPosition, Quaternion.identity, map.transform);
                x = Random.Range(-9, 9);
                y = Random.Range(-9, 9);
                z = Random.Range(-9, 9);
                BoxPosition = new Vector3(x, y, z);
            }
            for(p = 0; p < 10; p++){
                Instantiate(Box3, BoxPosition, Quaternion.identity, map.transform);
                x = Random.Range(-9, 9);
                y = Random.Range(-9, 9);
                z = Random.Range(-9, 9);
                BoxPosition = new Vector3(x, y, z);  
            }
            for(i = 0; i < 300; i++){
                Instantiate(Box4, BoxPosition, Quaternion.identity, map.transform);
                x = Random.Range(-9, 9);
                y = Random.Range(-9, 9);
                z = Random.Range(-9, 9);
                BoxPosition = new Vector3(x, y, z);
            }

            InstantiateTarget();
            
        }


    }




    void Start()
    {
        enemiesNumber = PlayerPrefs.GetFloat("slidervalue");
        PlayerPrefs.SetFloat("enemiesnum", enemiesNumber);

        
    }

    void InstantiateTarget(){
    
        for(t = 0; t<enemiesNumber; t++){
            x = Random.Range(-9, 9);
            y = Random.Range(-9, 9);
            z = Random.Range(-9, 9);
            TargetPosition = new Vector3(x, y, z);  
            Instantiate(Target, TargetPosition, Quaternion.identity, map.transform);
        }
    }

    void Update(){

        pauseText.enabled = true;

        StartGame = PlayerPrefs.GetInt("Start");
        
        
        if(StartGame == 1 && gameStarted == 0){
            StartGame1();  
        } 

        






    }
}
