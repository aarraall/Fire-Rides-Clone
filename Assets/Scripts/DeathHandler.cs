using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        //rb.velocity = Vector3.zero;
        //rb.useGravity = false;
        //rb.constraints = RigidbodyConstraints.FreezeAll;
        //GetComponentInChildren<MeshRenderer>().enabled = false;
        Time.timeScale = 0;
        FindObjectOfType<UIHandler>().HandleGameOverScreen();
    }
}
