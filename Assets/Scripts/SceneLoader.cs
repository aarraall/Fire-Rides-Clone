using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
     void Start()
    {
        FindObjectOfType<UIHandler>().HandleMainMenu();
    }
    public void StartGame()
    {
        FindObjectOfType<UIHandler>().HandleGameScreenUI();
    }
    public void ReloadGame()
    {
        FindObjectOfType<UIHandler>().HandleAfterReload();    
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
