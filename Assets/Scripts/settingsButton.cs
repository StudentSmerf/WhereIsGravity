using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsButton : MonoBehaviour
{
    public bool click;

    public void OnClick(bool click){
    
        SceneManager.LoadScene("Settings");
    
    }
}
