﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object
    public Camera cam;


    public float offset = 5;         //Private variable to store the offset distance between the player and camera
    public Vector3 mouseRotation = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //float rotX = Input.GetAxis("CameraX");
        //float rotY = Input.GetAxis("CameraY");
        //Debug.Log(rotX.ToString() + " " + rotY.ToString());
        //transform.Rotate(rotY, rotX, 0);
        //transform.position = player.transform.position + offset;

        offset = 5;

        mouseRotation.x += Input.GetAxis("CameraY");
        mouseRotation.y += Input.GetAxis("CameraX");

        this.transform.position = player.transform.position;
        this.transform.rotation = Quaternion.Euler(mouseRotation.x, mouseRotation.y, 0);
        this.transform.position -= transform.forward * offset;

        RaycastHit hitInfo;

        Debug.DrawLine(player.transform.position, transform.position, Color.green);

        Physics.Linecast(player.transform.position, transform.position, out hitInfo);
        if (hitInfo.transform != null)
        {
            Debug.Log("hit");
            transform.position = player.transform.position + (transform.forward * -(hitInfo.distance - cam.nearClipPlane));
            Debug.DrawLine(player.transform.position, transform.position, Color.red);
        }

        //this.transform.position -= transform.forward * offset;




    }
}
