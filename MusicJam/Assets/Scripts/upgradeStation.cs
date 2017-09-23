using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class upgradeStation : MonoBehaviour {

	public GameObject shooter;
	public bool c1 = false;
	public bool c2 = false;
	public bool ca = false;
    public bool c3 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		if (c1) {
			shooter.GetComponent<bulletScript> ().EL1 = true;
		}
		if (c2) {
			shooter.GetComponent<bulletScript> ().EL2 = true;
		}
		if (ca) {
			shooter.GetComponent<bulletScript> ().ELA = true;
		}
        if(c3)
        {
            shooter.GetComponent<bulletScript>().EL3 = true;
            BinaryWriter br = new BinaryWriter(File.OpenWrite("data.dat"));
            br.Write(true);
            br.Close();
        }
	}
}
