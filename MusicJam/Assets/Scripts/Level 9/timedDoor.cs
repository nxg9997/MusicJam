using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedDoor : MonoBehaviour {

	public GameObject door;
	public float time;
	public AudioClip doorLock;
	public GameObject player;

	private Vector3 dLoc;
	private Quaternion dRot;
	private GameObject doorClone;

	// Use this for initialization
	void Start () {
		dLoc = door.transform.position;
		dRot = door.transform.rotation;
		doorClone = Instantiate (door, new Vector3 (1000, 1000, 1000), dRot);
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
				AudioSource.PlayClipAtPoint (doorLock, transform.position);
				StartCoroutine (timer ());
			}
		}
	}

	IEnumerator timer () {
		yield return new WaitForSecondsRealtime (time);
		door = Instantiate (doorClone, dLoc, dRot);
		Debug.Log ("locked door");
		AudioSource.PlayClipAtPoint (doorLock, player.transform.position);
	}
}
