using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeStation : MonoBehaviour {

	public GameObject shooter;
	private bool complete = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		if (!complete) {
			shooter.GetComponent<bulletScript> ().EL1 = !shooter.GetComponent<bulletScript> ().EL1;
			complete = true;
		}
	}
}
