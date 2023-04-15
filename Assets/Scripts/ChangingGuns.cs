using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingGuns : MonoBehaviour
{


    public GameObject Gun, GrapplingGun;
    public bool GunIsUsed;

    
    public MeshRenderer Mr1;
    public MeshRenderer Mr2;
    void Start()
    {
        
        Gun = GameObject.Find("Gun");
        GrapplingGun = GameObject.Find("Grappling Gun");

        MeshRenderer Mr1 = Gun.GetComponent<MeshRenderer>();
        MeshRenderer Mr2 = GrapplingGun.GetComponent<MeshRenderer>();

        GunIsUsed = true;
        Mr1.enabled = true;
        Mr2.enabled = false;
            
        PlayerPrefs.SetInt("IsGun", 1);
    }


    void Update()
    {

        if(PlayerPrefs.GetInt("IsGun") == 1){
            GunIsUsed = true;
        }
        if(PlayerPrefs.GetInt("IsGun") == 0){
            GunIsUsed = false;
        }



        if(Input.GetKeyDown("q") & GunIsUsed == true)
        {
            
            GunIsUsed = false;
            PlayerPrefs.SetInt("IsGun", 0);
        }

        if (Input.GetKeyDown("e") & GunIsUsed == false)
        {
            
            GunIsUsed = true;
            PlayerPrefs.SetInt("IsGun", 1);
        }




        if(PlayerPrefs.GetInt("IsGun") == 1){
            Mr1.enabled = true;
            Mr2.enabled = false;
        }

        if(PlayerPrefs.GetInt("IsGun") == 0){
            Mr1.enabled = false;
            Mr2.enabled = true;
        }
    }
}
