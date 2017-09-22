using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2Collisions : MonoBehaviour {

	//attributes
	//public countScript counter;
	public GameObject explosion;
	public AudioClip explosionSound;
	public GameObject blood;

    private GameObject player;
    private ScannerEffect2Demo scanner2;

	// Use this for initialization
	void Start () {
        //counter = GameObject.Find ("counter").GetComponent<countScript> ();
        player = GameObject.Find("Player");
        scanner2 = player.GetComponentInChildren<ScannerEffect2Demo>();
        Debug.Log("Test");
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
		//AudioSource.PlayClipAtPoint (explosionSound, transform.position);

        // Only triggers against enemies
        if(collision.collider.gameObject.tag == "Enemy")
        {
            scanner2.isHit = true;
        }
        Destroy (gameObject);

	}
}
