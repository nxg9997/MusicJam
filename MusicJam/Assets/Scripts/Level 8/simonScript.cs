using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simonScript : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject door;

	public AudioClip p1Snd;
	public AudioClip p2Snd;
	public AudioClip p3Snd;
	public AudioClip p4Snd;

	private int currSequence = 1;


	// Use this for initialization
	void Start () {
		//Sequence1 ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (currSequence) {
		case 1:
			StartCoroutine (Sequence1 ());
			currSequence = -1;
			break;
		case -1:
			Sequence1Check ();
			break;
		case 2:
			StartCoroutine (Sequence2 ());
			currSequence = -2;
			break;
		case -2:
			Sequence2Check ();
			break;
		case 3:
			StartCoroutine (Sequence3 ());
			currSequence = -3;
			break;
		case -3:
			Sequence3Check ();
			break;
		}
	}

	/*void Sequence1 () {
		
		StartCoroutine (wait ());
	}*/

	IEnumerator Sequence1 () {
		AudioSource.PlayClipAtPoint (p1Snd, p1.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p2Snd, p2.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p3Snd, p3.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p4Snd, p4.transform.position);
		currSequence = -1;
	}

	IEnumerator Sequence2 () {
		AudioSource.PlayClipAtPoint (p2Snd, p2.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p1Snd, p1.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p4Snd, p4.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p3Snd, p3.transform.position);
		currSequence = -2;
	}

	IEnumerator Sequence3 () {
		AudioSource.PlayClipAtPoint (p3Snd, p3.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p2Snd, p2.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p4Snd, p4.transform.position);
		yield return new WaitForSecondsRealtime (3);
		AudioSource.PlayClipAtPoint (p1Snd, p1.transform.position);
		currSequence = -3;

	}

	void Sequence1Check () {
		if (p1.GetComponent<pillarScript> ().hit) {
			if (p2.GetComponent<pillarScript> ().hit) {
				if (p3.GetComponent<pillarScript> ().hit) {
					if (p4.GetComponent<pillarScript> ().hit) {
						Debug.Log ("finished 1!");
						currSequence = 2;
						ResetPillars ();
					}
				}
				else {
					p4.GetComponent<pillarScript> ().hit = false;
				}
			}
			else {
				p2.GetComponent<pillarScript> ().hit = false;
				p3.GetComponent<pillarScript> ().hit = false;
				p4.GetComponent<pillarScript> ().hit = false;
			}
		} 
		else {
			p2.GetComponent<pillarScript> ().hit = false;
			p3.GetComponent<pillarScript> ().hit = false;
			p4.GetComponent<pillarScript> ().hit = false;
		}
	}

	void Sequence2Check () {
		if (p2.GetComponent<pillarScript> ().hit) {
			if (p1.GetComponent<pillarScript> ().hit) {
				if (p4.GetComponent<pillarScript> ().hit) {
					if (p3.GetComponent<pillarScript> ().hit) {
						Debug.Log ("finished 2!");
						currSequence = 3;
						ResetPillars ();
					}
				}
				else {
					p3.GetComponent<pillarScript> ().hit = false;
				}
			}
			else {
				p3.GetComponent<pillarScript> ().hit = false;
				p1.GetComponent<pillarScript> ().hit = false;
				p4.GetComponent<pillarScript> ().hit = false;
			}
		} 
		else {
			p3.GetComponent<pillarScript> ().hit = false;
			p1.GetComponent<pillarScript> ().hit = false;
			p4.GetComponent<pillarScript> ().hit = false;
		}
	}

	void Sequence3Check () {
		if (p3.GetComponent<pillarScript> ().hit) {
			if (p2.GetComponent<pillarScript> ().hit) {
				if (p4.GetComponent<pillarScript> ().hit) {
					if (p1.GetComponent<pillarScript> ().hit) {
						Debug.Log ("finished 3!");
						Destroy (door);
						currSequence = 4;
						ResetPillars ();
					}
				}
				else {
					p1.GetComponent<pillarScript> ().hit = false;
				}
			}
			else {
				p2.GetComponent<pillarScript> ().hit = false;
				p1.GetComponent<pillarScript> ().hit = false;
				p4.GetComponent<pillarScript> ().hit = false;
			}
		} 
		else {
			p2.GetComponent<pillarScript> ().hit = false;
			p3.GetComponent<pillarScript> ().hit = false;
			p4.GetComponent<pillarScript> ().hit = false;
		}
	}

	void ResetPillars () {
		p1.GetComponent<pillarScript> ().hit = false;
		p2.GetComponent<pillarScript> ().hit = false;
		p3.GetComponent<pillarScript> ().hit = false;
		p4.GetComponent<pillarScript> ().hit = false;
	}
}
