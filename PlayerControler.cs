﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject shot;
    public Transform firePosition;
    float speed = 5;
    float tilt = 5;

    
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetButtonDown("Fire1") == true)
        {
            Instantiate(shot, firePosition.position, firePosition.rotation);

        }

    }



    void FixedUpdate()
    {


        float dirX = Input.GetAxis("Horizontal");
        float dirY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(dirX, 0, dirY);

        GetComponent<Rigidbody>().velocity = movement * speed;
        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0, 0, GetComponent<Rigidbody>().velocity.x * -tilt);
    }
}