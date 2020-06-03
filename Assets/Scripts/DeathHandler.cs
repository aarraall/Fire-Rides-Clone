using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<UIHandler>().HandleGameOverScreen();
    }
}
