using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeStation : MonoBehaviour {

	public GameObject shooter;
	public bool c1 = false;
	public bool c2 = false;
	public bool ca = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		if (c1) {
			shooter.GetComponent<bulletScript> ().EL1 = true;
			c1 = true;
		}
		if (c2) {
			shooter.GetComponent<bulletScript> ().EL2 = true;
			c2 = true;
		}
		if (ca) {
			shooter.GetComponent<bulletScript> ().ELA = true;
			ca = true;
		}
	}
}
