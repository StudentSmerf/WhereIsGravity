using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Camera Playercamera;
    public float mouseSensivity = 1f;
    public Vector3 rotation1;
    public Vector3 rotation2;

    public Vector3 rotation3;
    void Update()
    {
        float _yRot = Input.GetAxisRaw("Mouse X");
        float _xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _rotation1 = new Vector3 (-_xRot, 0f, 0f) * mouseSensivity;
        Vector3 _rotation2 = new Vector3 (0f, _yRot, 0f) * mouseSensivity;
        Vector3 _rotation3 = new Vector3 (0, 0, 0) * 2f;
        

        if(Playercamera.transform.rotation.z > 20f){
            _rotation3 = new Vector3 (0, 0, -10f) * 2f;
        }
        if(Playercamera.transform.rotation.z < -20f){
            _rotation3 = new Vector3 (0, 0, 10f) * 2f;
        }



        rotation1 = _rotation1;
        rotation2 = _rotation2;
        rotation3 = _rotation3;

        Rotate();


        
    }

    void Rotate(){
        Playercamera.transform.Rotate(rotation1);
        Playercamera.transform.Rotate(rotation2);
        Playercamera.transform.Rotate(rotation3);
        
    }
}
