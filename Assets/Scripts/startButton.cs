
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public bool click;
    public int startint = 0;

    void Start(){
        //Screen.lockCursor = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnClick(bool click){
        //SceneManager.UnloadSceneAsync("StartScene");
        SceneManager.LoadScene("SampleScene");
        startint = 1;
        PlayerPrefs.SetInt("Start", startint);

    }


}
