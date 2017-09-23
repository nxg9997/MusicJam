using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillarScript : MonoBehaviour {

	public GameObject bullet;
	public bool hit;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Bullet")
		{
			hit = true;
			Debug.Log ("hit true");
			//receiver.receiverValue = value;
			//AudioSource.PlayClipAtPoint(sound, transform.position);
		}
	}
}
