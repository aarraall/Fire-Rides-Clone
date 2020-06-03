using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] Canvas menuUI;
    [SerializeField] Canvas gameScreenUI;
    [SerializeField] Canvas gameOverScreenUI;
    private void Start()
    {
        menuUI.enabled = false;
        gameScreenUI.enabled = false;
        gameOverScreenUI.enabled = false;
        HandleMainMenu();
    }
    public void HandleGameOverScreen()
    {
        Time.timeScale = 0;
        gameScreenUI.enabled = false;
        gameOverScreenUI.enabled = true;
    }
    public void HandleGameScreenUI()
    {
        Time.timeScale = 1;
        gameScreenUI.enabled = true;
        menuUI.enabled = false;
        
    }
    private void HandleMainMenu()
    {
        gameScreenUI.enabled = false;
        gameOverScreenUI.enabled = false;
        menuUI.enabled = true;
        Time.timeScale = 0;
    }
}