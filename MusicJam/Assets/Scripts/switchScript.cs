using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchScript : MonoBehaviour {

	public GameObject door;
	public GameObject player;
	public AudioClip unlockSnd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UnlockDoor ();
	}

	void UnlockDoor(){
		Ray newRay = new Ray (transform.position, transform.forward);
		RaycastHit rch;

		//RaycastHit rch = //Physics.Raycast (transform.position, transform.forward, 1);
		//Physics.Raycast(newRay, RaycastHit rch,
		if (Physics.Raycast (newRay, out rch, 1)) {
			if ((rch.collider.name == "Player") && Input.GetKeyDown (KeyCode.E)) {
				Destroy (door);
				Debug.Log ("door unlocked");
			}
		}
	}
}
