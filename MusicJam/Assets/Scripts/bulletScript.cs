﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	//attributes
	public GameObject bullet;
    public GameObject bullet2;
	public GameObject fpc;
	public int bulletSpeed;
	public AudioClip fired;
	public bool EL1 = false;
    public bool EL2 = false;
    public bool ELA = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Shoot (); //calls shoot method once per frame
	}

	/// <summary>
	/// Method for shooting bullets, checks if left mouse button is clicked, if it is, a bullet instance is created, and the bullet is propelled in the direction the player is facing
	/// </summary>
	void Shoot(){
		if (Input.GetButtonDown("Fire1") && EL1) {
			Debug.Log ("Shot");
			//AudioSource.PlayClipAtPoint (fired, fpc.transform.position);
			GameObject projectile = Instantiate (bullet, new Vector3(fpc.transform.position.x, fpc.transform.position.y, fpc.transform.position.z), fpc.transform.rotation) as GameObject;
			projectile.transform.rotation = new Quaternion (fpc.transform.rotation.x, 90, fpc.transform.rotation.z, fpc.transform.rotation.w);

			projectile.GetComponent<Rigidbody> ().AddForce (fpc.transform.forward * bulletSpeed);
			//bullet.GetComponent<Rigidbody> ().velocity = new Vector3 (10, 0, 0);

		}
        if(Input.GetButtonDown("Fire2") && ELA)
        {
            GameObject projectile = Instantiate(bullet2, new Vector3(fpc.transform.position.x, fpc.transform.position.y, fpc.transform.position.z), fpc.transform.rotation) as GameObject;
            projectile.transform.rotation = new Quaternion(fpc.transform.rotation.x, 90, fpc.transform.rotation.z, fpc.transform.rotation.w);

            projectile.GetComponent<Rigidbody>().AddForce(fpc.transform.forward * bulletSpeed);
        }
	}
}
