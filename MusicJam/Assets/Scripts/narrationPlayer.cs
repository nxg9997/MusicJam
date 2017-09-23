using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrationPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Narration Trigger")
        {
            narrationTrigger trigger = hit.gameObject.GetComponent<narrationTrigger>();
            trigger.enabled = true;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
