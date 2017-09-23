using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narration : MonoBehaviour {

    public AudioSource narration1;
    public AudioSource narration2;
    public AudioSource narration3;
    public AudioSource narration4;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Transform currentPosition;
    public bool play1 = false;
    public bool play2 = false;
    public bool play3 = false;
    public bool play4 = false;
    public bool followActive = false;

    public AudioSource[] follow;

    private bool isLooping = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if(play1 && narration1 != null)
        {
            StopNarration();
            narration1.Play();
            play1 = false;
        }
        if(play2 && narration2 != null)
        {
            StopNarration();
            narration2.Play();
            play2 = false;
        }
        if(play3 && narration3 != null)
        {
            StopNarration();
            narration3.Play();
            play3 = false;
        }
        if(play4 && narration4 != null)
        {
            StopNarration();
            narration4.Play();
            play4 = false;
        }
        if(followActive && follow != null && !isLooping)
        {
            int index = Random.Range(0, follow.Length);
            isLooping = true;
            StartCoroutine(DelaySound(10, follow[index]));
        }
	}

    // Method for delaying sound
    IEnumerator DelaySound(float seconds, AudioSource sound)
    {
        yield return new WaitForSeconds(seconds);
        if(followActive)
        {
            StopNarration();
            sound.Play();
        }
        isLooping = false;
    }

    // Method for stopping all narration that is playing
    void StopNarration()
    {
        if (narration1 != null && narration1.isPlaying)
        {
            narration1.Stop();
        }
        if (narration2 != null && narration2.isPlaying)
        {
            narration2.Stop();
        }
        if (narration3 != null && narration3.isPlaying)
        {
            narration3.Stop();
        }
        if (narration4 != null && narration4.isPlaying)
        {
            narration4.Stop();
        }
        if(follow != null)
        {
            foreach (AudioSource audio in follow)
            {
                audio.Stop();
            }
        }
    }
}
