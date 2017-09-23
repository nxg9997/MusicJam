using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrationTrigger : MonoBehaviour {

    public bool narration1 = false;
    public bool narration2 = false;
    public bool narration3 = false;
    public bool narration4 = false;

    private GameObject manager;
    
	// Use this for initialization
	void Start () {
        manager = GameObject.Find("Manager");
	}
	
	// Update is called once per frame
	void Update () {
        narration narration = manager.GetComponent<narration>();
        narration.followActive = false;
        if (narration1)
        {
            narration.play1 = true;
        }
        if (narration2)
        {
            narration.play2 = true;
        }
        if (narration3)
        {
            narration.play3 = true;
        }
        if (narration4)
        {
            narration.play4 = true;
        }
        Destroy(gameObject);
    }
}
