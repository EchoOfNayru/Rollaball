﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public GameObject MainCamera;

    public Rigidbody rb;
    public float speed;
    public float jumpStr;
    public static int score;
    public bool isGrounded;
    public bool onRail;
    // Use this for initialization
    void Start() {
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate() {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 move = new Vector3(horizontal, 0, -vertical);

        Debug.Log(move);

        move = Quaternion.LookRotation(Vector3.Normalize
                                              ( new Vector3(transform.position.x, 0, transform.position.z)
                                              - new Vector3(MainCamera.transform.position.x, 0, MainCamera.transform.position.z)))
                                              * move;

        Debug.DrawLine(transform.position, transform.position + move, Color.green);

        rb.AddForce(move * speed * Time.deltaTime);

        if (isGrounded)
        {
            Vector3 jumping = new Vector3(0, jump, 0);
            rb.AddForce(jumping * jumpStr, ForceMode.Impulse);
            isGrounded = false;
        }

        onRail = false;
    }

    private void OnCollisionEnter()
    {
       
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("happened");
        if (collision.gameObject.tag == "floor")
        {
            isGrounded = true;
        }
    }
}
