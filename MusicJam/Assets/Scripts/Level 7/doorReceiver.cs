using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorReceiver : MonoBehaviour {

    public int receiverValue; // NEVER SET TO -1
    public int[] order;
    public AudioClip wrongSound;
    public AudioClip doorOpens;

    private GameObject player;
    private int index;

	// Use this for initialization
	void Start () {
        index = 0;
        receiverValue = -1;
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        // Test when a value is received
		if(receiverValue != -1)
        {
            // Check if it is the right value in the current pattern
            if(order[index] == receiverValue)
            {
                index++;
                receiverValue = -1;
            }
            else // Wrong order - Reset the pattern
            {
                index = 0;
                receiverValue = -1;
                StartCoroutine(DelaySound(1, wrongSound));
            }
        }

        // Reaches the end of the pattern - Succeeded
        if(index == order.Length)
        {
            StartCoroutine(DelaySound(1, doorOpens));
            StartCoroutine(DelayDestroy(1));
        }
	}

    // Method for delaying sound
    IEnumerator DelaySound(float seconds, AudioClip sound)
    {
        yield return new WaitForSeconds(seconds);
        AudioSource.PlayClipAtPoint(sound, player.transform.position);
    }

    // Method for delaying destroying the game object
    IEnumerator DelayDestroy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
