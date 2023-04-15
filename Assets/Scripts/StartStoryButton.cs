using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStoryButton : MonoBehaviour
{
    public void OnClick(){
        SceneManager.LoadScene("StoryMode1");
    }
}
