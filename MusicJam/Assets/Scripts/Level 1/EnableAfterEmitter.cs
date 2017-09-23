using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAfterEmitter : MonoBehaviour {

    public GameObject trigger2;
    public GameObject door;

    private GameObject player;
    private bulletScript bulletPlayer;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        bulletPlayer = player.GetComponent<bulletScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(bulletPlayer.EL1)
        {
            if(trigger2 != null)
            {
                trigger2.SetActive(true);
                Destroy(door);
            }
        }
	}
}
