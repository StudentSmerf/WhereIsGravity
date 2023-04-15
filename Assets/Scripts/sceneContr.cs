
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneContr : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadSceneAsync("FirstScene"); 
        Screen.SetResolution(1920, 1080, false);
    }


}
