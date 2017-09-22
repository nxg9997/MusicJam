using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollisions : MonoBehaviour {

	//attributes
	//public countScript counter;
	public GameObject explosion;
	public AudioClip explosionSound;
	public GameObject blood;

	// Use this for initialization
	void Start () {
		//counter = GameObject.Find ("counter").GetComponent<countScript> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	/// <summary>
	/// Raises the collision enter event.
	/// </summary>
	/// <param name="collision">Collision.</param>
	void OnCollisionEnter(Collision collision){
		Debug.Log ("hit");
		AudioSource.PlayClipAtPoint (explosionSound, transform.position);
		Destroy (gameObject);

	}
}
