﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<UIHandler>().HandleGameScreenUI();
    }
    public void ReloadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}