using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayAudio : MonoBehaviour
{
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<GamePlayAudio>().Length;
        if (numMusicPlayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
