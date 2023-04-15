

using UnityEngine;



[RequireComponent(typeof(PlayerMotor))]




public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float mouseSensivity = 1f;

    void start ()
    {
       mouseSensivity = PlayerPrefs.GetFloat("Sensitivity");
    }




    void Update()
    {
        
        float _yRot = Input.GetAxisRaw("Mouse X");
        float _xRot = Input.GetAxisRaw("Mouse Y");

        Vector3 _rotation = new Vector3 (-_xRot, 0f, 0f) * mouseSensivity;
        Vector3 _cameraRotation = new Vector3 (0f, _yRot, 0f) * mouseSensivity;


        GetComponent<PlayerMotor>().Rotate(_rotation);
        GetComponent<PlayerMotor>().RotateCamera(_cameraRotation);
    }
}
