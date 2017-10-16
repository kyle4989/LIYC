using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControler : MonoBehaviour {


    public GameObject shot;
    public Transform fireposition;



	void Start () {

        InvokeRepeating("Fire", 1, 2);

	}
	
    void Fire()
    {

        Instantiate(shot, fireposition.position, fireposition.rotation);

    }
	
}
