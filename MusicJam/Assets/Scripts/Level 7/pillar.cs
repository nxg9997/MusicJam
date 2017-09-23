using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillar : MonoBehaviour {

    public int value;
    public AudioClip sound;
    public doorReceiver receiver;

	// Use this for initialization
	void Start () {
		
	}
	
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            receiver.receiverValue = value;
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
