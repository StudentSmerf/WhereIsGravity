using UnityEngine;



public class hitSth : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 direction;
    public GameObject me;
    public GameObject Player;
    public Collision collision;
    public AudioSource audio1;
    

    void Start()
    {
        Player = GameObject.Find("Player(Clone)");
        PlayerMotor playerMotor = Player.GetComponent<PlayerMotor>();
        direction = playerMotor.directionForward;

        rb.AddForce(direction * 110f);

        
        Destroy(me, 6f);
    }

  
    void OnCollisionEnter(Collision collision){
        
        if(collision.gameObject.tag == "Target")
        {   
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Box")
        {   
            Destroy(collision.gameObject);
            audio1.Play();
        }
        if(collision.gameObject.tag == "RedBox")
        {   
            Destroy(collision.gameObject);
        }

        else{
        Destroy(me);
        }
        
    }
   
}
