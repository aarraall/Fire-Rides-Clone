using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    [SerializeField] Canvas menuUI;
    [SerializeField] Canvas gameScreenUI;
    [SerializeField] Canvas gameOverScreenUI;

    public void HandleMainMenu()
    {
        Time.timeScale = 0;
        gameScreenUI.enabled = false;
        gameOverScreenUI.enabled = false;
        menuUI.enabled = true;
    }
    public void HandleGameScreenUI()
    {
        Time.timeScale = 1;
        gameScreenUI.enabled = true;
        menuUI.enabled = false;
        gameOverScreenUI.enabled = false;
    }
    public void HandleGameOverScreen()
    {
        Time.timeScale = 0;
        gameScreenUI.enabled = false;
        gameOverScreenUI.enabled = true;
        
    }
    public void HandleAfterReload()
    {
        FindObjectOfType<Player>().transform.position = new Vector3 (0,0,0);
        FindObjectOfType<Rigidbody>().velocity = Vector3.zero;
        menuUI.enabled = false;
        gameOverScreenUI.enabled = false;
        gameScreenUI.enabled = true;
        Time.timeScale = 1;
        FindObjectOfType<Score>().ResetScore();
    }
}