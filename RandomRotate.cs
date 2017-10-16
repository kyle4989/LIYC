using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotate : MonoBehaviour
{

    float tumble = 5;


    void Start()
    {


        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;

    }
}