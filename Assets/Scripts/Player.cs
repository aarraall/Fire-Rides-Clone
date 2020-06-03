using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    bool jump = false;
    Vector3 vec;

    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] Transform playerRig;
    private void Start()
    {
        rb = GetComponentInChildren<Rigidbody>();
        playerRig = Camera.main.transform.parent;
    }
    private void Update()
    {
        CameraHolder();
        PushForward();
        
        if (Input.GetKeyUp(KeyCode.Space))
        {   
            jump = true;   
            Jump();
        }
    }

    private void Jump()
    {   
        if (jump)
        {
            rb.AddForce(Vector3.up * 1000 * jumpForce * Time.deltaTime);
            jump = false;
        }
    }

    private void PushForward()
    {
        rb.AddForce(Vector3.right * speed * Time.deltaTime);
    }
    void CameraHolder()
    {
        vec.x = transform.position.x;
        vec.y = playerRig.position.y;
        vec.z = playerRig.position.z;

        playerRig.position = vec;
    }
}
