using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTrigger : MonoBehaviour {

    public GameObject source;
    public GameObject[] triggers;
    public Vector3[] newPosition;

    private GameObject manager;
    private int index;

	// Use this for initialization
	void Start () {
        manager = GameObject.Find("Manager");
        index = 0;
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Narration Trigger")
        {
            foreach(GameObject obj in triggers)
            {
                if(hit.gameObject == obj)
                {
                    narration narration = manager.GetComponent<narration>();
                    narration.followActive = true;
                    source.transform.position = newPosition[index];
                    index++;
                    Destroy(obj);
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
