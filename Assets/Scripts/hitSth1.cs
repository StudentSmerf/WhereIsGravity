
using UnityEngine;



public class hitSth1 : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 direction;
    public Vector3 FakePlayerPos;
    public GameObject me;
    public GameObject Player;
    public GameObject FakePlayer;
    public GameObject Target;
    public Collision collision;
    public Vector3 PlayerPosition;
    public AudioSource audio1;
    
    void Start()
    {
        /*Target = GameObject.Find("Target(Clone)");
        TargetScript targetScript = Target.GetComponent<TargetScript>();
        direction = targetScript.directionForward;
        */
        Player = GameObject.Find("Player(Clone)");
        Transform Playertransform = Player.GetComponent<Transform>();
        PlayerPosition = Playertransform.position;
        direction = PlayerPosition - me.transform.position;
        
        rb.AddForce(direction * 10f);
        
        Destroy(me, 7f);
        
    }
    void Update(){
        rb.angularVelocity = Vector3.zero;
    }
  
    void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.tag != "Respawn" && collision.gameObject.tag != "Player")
        {
            Destroy(collision.gameObject);
            
        }
        if(collision.gameObject.tag == "Box")
        {   
            audio1.Play();
        }
        else{
        Destroy(me);
        }
        
    }
   
}
