using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugScript : MonoBehaviour {

    // Attributes
    public Light light; // Place the light on the First Person Character into here
    public Camera camera; // Place the First Person Camera into here

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        // Toggle "blind" on or off
		if(Input.GetKeyDown(KeyCode.L))
        {
            if(camera.backgroundColor == Color.black)
            {
                camera.backgroundColor = Color.white;
                light.enabled = true;
            }
            else
            {
                camera.backgroundColor = Color.black;
                light.enabled = false;
            }
        }
	}
}
