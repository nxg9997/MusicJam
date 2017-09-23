using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rogueEmitterScript : MonoBehaviour {

	public AudioSource song;
	//public AudioClip song2;
	public GameObject bullet;
	private bool active = true;



	// Use this for initialization
	void Start () {
		
		//AudioSource.PlayClipAtPoint (song, transform.position);
		//song.PlayOneShot(song.GetComponent<AudioClip>());
	}
	
	// Update is called once per frame
	void Update () {
		if (!active) {
			//AudioSource.PlayClipAtPoint (song2, transform.position);
			song.Stop();
		}
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name.Contains ("bullet2")) {
			active = false;
			gameObject.tag = "Untagged";
		}
	}
}
