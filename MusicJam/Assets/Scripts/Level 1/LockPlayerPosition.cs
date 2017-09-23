using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class LockPlayerPosition : MonoBehaviour {

    public AudioSource beginningDialogue;
    public float speed;

    private GameObject player;
    private GameObject manager;
    private bool moveEnabled = false;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        manager = GameObject.Find("Manager");
        beginningDialogue.Play();
        Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Delay(30));
        if(moveEnabled)
        {
            transform.position += new Vector3(speed, 0, 0);
            if(transform.position.x > 30)
            {
                narration narrate = manager.GetComponent<narration>();
                narrate.followActive = true;
                Destroy(this);
            }
        }
	}

    // Delay
    IEnumerator Delay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        FirstPersonController script = player.GetComponent<FirstPersonController>();
        script.enabled = true;
        moveEnabled = true;
    }
}
