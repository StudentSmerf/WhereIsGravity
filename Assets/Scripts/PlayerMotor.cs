using System.Collections;
using UnityEngine.SceneManagement;

using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMotor : MonoBehaviour
{
    private Vector3 rotation = Vector3.zero;
    private Vector3 cameraRotation = Vector3.zero;
    public Rigidbody rb;
    public Camera cam;
    public GameObject Camera;
    public GameObject PointA;
    public GameObject PointB;
    public GameObject Me;
    public Vector3 directionForward;
    public bool onground = true;
    public bool died = false;
    public GameObject Bullet;
    public GameObject Gun;
    private Vector3 PointAVec;
    private Vector3 PointBVec;
    public int Ammo = 50;
    public float health = 100;
    public float Dm = 30;
    public AudioSource audioSource;
    public AudioSource audioSource2;



    void start()
    {
        rb = GetComponent<Rigidbody>();
        PlayerPrefs.SetString("win", "lose");
        
    }
    void Awake(){
        health = PlayerPrefs.GetFloat("HpSlider");
        Dm = PlayerPrefs.GetFloat("DmSlider");
        
        cam.clearFlags = CameraClearFlags.Skybox;
    }

    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }
    public void RotateCamera(Vector3 _cameraRotation)
    {
        cameraRotation = _cameraRotation;
    }
    
    void OnCollisionEnter(Collision collision){
        onground = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        if(collision.gameObject.tag == "BlueBox"){
            Ammo = Ammo + 20;
        }
        if(collision.gameObject.tag == "GreenBox"){
            health = health + 25;
        }
        if(collision.gameObject.tag == "RedBox"){
            health = health - Dm;
        }
    }
    
    
    void Update()
    {  
  
        Cursor.visible = false;
        

        
        PointA = GameObject.Find("A");
        PointAVec = PointA.transform.position;
        PointB = GameObject.Find("B");
        PointBVec = PointB.transform.position;
        directionForward = PointAVec - PointBVec;

        PerformRotation();

        if(health<=0){
            Die();
        }

        
        if(Input.GetKeyDown("space") & onground == true){
            
            StartCoroutine("jump");
        }
        if(Input.GetButtonDown("Fire1") & Ammo>0){
            Shoot();
        }


        if(Input.GetKeyDown("escape")){
            SceneManager.LoadScene("StartScene");
        }


        if(rotation == Vector3.zero && cameraRotation == Vector3.zero){
            rb.angularVelocity = Vector3.zero;
        }
    }
    IEnumerator jump(){
        audioSource.PlayScheduled(0);
        yield return new WaitForSeconds(0.5f);
        rb.AddForce(directionForward * 130f);
        onground = false;
    }

    void Shoot(){
        
        if(PlayerPrefs.GetInt("IsGun") == 1){
            Instantiate(Bullet, Gun.transform.position + cam.transform.forward * 0.5f, Quaternion.identity);
            Ammo = Ammo - 1;
            audioSource2.Play();
        }
    }
    void PerformRotation()
    {
        cam.transform.Rotate(rotation);
        cam.transform.Rotate(cameraRotation);
    }
    void Die(){
        if(died != true){
            cam.fieldOfView = 0.2f;
            died = true;
        }
    }
}
