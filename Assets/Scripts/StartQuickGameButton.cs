using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuickGameButton : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("StartScene");
    }
}
