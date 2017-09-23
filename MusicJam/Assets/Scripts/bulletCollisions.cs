using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCollisions : MonoBehaviour {

	//attributes
	//public countScript counter;
	public GameObject explosion;
	public AudioClip explosionSound;
	public GameObject blood;

    private GameObject player;
    private ScannerEffectDemo scanner;

	private GameObject pillar;

	// Use this for initialization
	void Start () {
        //counter = GameObject.Find ("counter").GetComponent<countScript> ();
        player = GameObject.Find("Player");
        scanner = player.GetComponentInChildren<ScannerEffectDemo>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	/// <summary>
	/// Raises the collision enter event.
	/// </summary>
	/// <param name="collision">Collision.</param>
	void OnCollisionEnter(Collision collision){
		AudioSource.PlayClipAtPoint (explosionSound, transform.position);
        scanner.isHit = true;
		//if (!collision.collider.name.Contains("pillar")){
			//pillar = collision.collider.GetComponentInParent<GameObject>();
			//collision.collider.gameObject.GetComponentInParent<pillarScript> ().hit = true;
			//Debug.Log ("hit pillar");
			Destroy (gameObject);
		//}
        

	}
}
