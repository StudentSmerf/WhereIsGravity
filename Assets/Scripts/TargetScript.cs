using System.Collections;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
  
    public GameObject Player;
    public GameObject Bullet;
    public GameObject Gun;
    public GameObject Me;
    public Rigidbody rb;
    public Vector3 PlayerPosition;
    public Vector3 directionForward;
    public Vector3 targetDirection;
    public int i;
    public int direction;
    public float fdirection;

    void Start(){
        StartCoroutine(ExistingCoroutine());
        
    }

    void Update()
    {
        if(GameObject.Find("Player(Clone)").activeSelf == true){
            Player = GameObject.Find("Player(Clone)");
            Transform Playertransform = Player.GetComponent<Transform>();
            PlayerPosition = Playertransform.position;
            transform.LookAt(PlayerPosition);
        

            directionForward = PlayerPosition - Gun.transform.position;
        }

    }

    IEnumerator ExistingCoroutine(){
        for (i = 0; i < 100; i++){
            yield return new WaitForSeconds(3);
            fdirection = Random.Range(1, 6);
            direction = Mathf.RoundToInt(fdirection);

            
            if(direction == 1){
                targetDirection = Vector3.forward;
            }
            if(direction == 2){
                targetDirection = Vector3.down;
            }
            if(direction == 3){
                targetDirection = Vector3.right;
            }
            if(direction == 4){
                targetDirection = Vector3.left;
            }
            if(direction == 5){
                targetDirection = Vector3.up;
            }
            if(direction == 6){
                targetDirection = -Vector3.forward;
            }
            
            
            
            
            rb.AddForce(targetDirection * 0.2f, ForceMode.Impulse);
            yield return new WaitForSeconds(Random.Range(3f, 6f));
            Shoot();
            
            rb.AddForce(-targetDirection * 0.2f);
        }
    }

    void Shoot(){
        Instantiate(Bullet, Gun.transform.position, Me.transform.rotation);
    }

} 
