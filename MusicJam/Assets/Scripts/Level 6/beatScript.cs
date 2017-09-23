using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beatScript : MonoBehaviour {

	public bool canPlay = false;
	public AudioSource maxHum;

	public float t1;
	public float t2;
	public float t3;
	public float t4;
	public float t5;

	//private bool press = false;

	private bool[] pressArr = new bool[5];
	private bool isPlaying = false;
	private int currStep = 0;
	private float sTime;

	// Use this for initialization
	void Start () {
		resetArr ();
		t2 = t2 + t1;
		t3 = t3 + t2;
		t4 = t4 + t3;
		t5 = t5 + t4;
	}
	
	// Update is called once per frame
	void Update () {
		if (canPlay) {
			maxHum.Play ();
			//StartCoroutine (hums ());
			canPlay = false;
			isPlaying = true;
		}
		if (isPlaying) {
			sTime = Time.time;
			//CheckPress (currStep);
		}
	}

	IEnumerator hums (){
		//CheckPress (0);
		//currStep++;
		if (currStep == 0){yield return new WaitForSecondsRealtime (t1);}
		//CheckPress (1);
		//currStep++;
		else if (currStep == 0){yield return new WaitForSecondsRealtime (t1);}
		//CheckPress (2);
		//currStep++;
		else if (currStep == 0){yield return new WaitForSecondsRealtime (t1);}
		//CheckPress (3);
		//currStep++;
		else if (currStep == 0){yield return new WaitForSecondsRealtime (t1);}
		//CheckPress (4);
		//currStep++;
		else if (currStep == 0){yield return new WaitForSecondsRealtime (t1);}
		//CheckCorrect ();
	}

	void CheckPress (int tStep){
		Debug.Log ("in checkpress");
		//float sTime = Time.time;
		//StartCoroutine (hums ());
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			pressArr [tStep] = true;
			Debug.Log ("good press");
		}
	}

	void resetArr () {
		for (int i = 0; i < 5; i++) {
			pressArr [i] = false;
		}
	}

	void CheckCorrect () {
		int cNum = 0;
		for (int i = 0; i < 5; i++) {
			if (pressArr [i] == true) {
				cNum++;
			}
		}

		if ((cNum == 5)) {
			Destroy (gameObject);
			isPlaying = false;
		} else {
			resetArr ();
			canPlay = true;
			currStep = 0;
		}
		Debug.Log ("Number Correct: " + cNum);
	}

	void OnMouseDown (){
		Debug.Log ("in mousedown");
		float eTime = Time.time - sTime;
		Debug.Log (eTime);
		if ((currStep == 0) && (eTime <= t1)) {
			Debug.Log ("good 1");
			pressArr [0] = true;
			currStep++;
		}
		else if ((currStep == 1) && (eTime <= t2) && (eTime > t1)) {
			Debug.Log ("good 2");
			pressArr [1] = true;
			currStep++;
		}
		else if ((currStep == 2) && (eTime <= t3) && (eTime > t2)) {
			Debug.Log ("good 3");
			pressArr [2] = true;
			currStep++;
		}
		else if ((currStep == 3) && (eTime <= t4) && (eTime > t3)) {
			Debug.Log ("good 4");
			pressArr [3] = true;
			currStep++;
		}
		else if ((currStep == 4) && (eTime >= t4)) {
			Debug.Log ("good 5");
			pressArr [4] = true;
			currStep++;
		}

		if (currStep == 5) {
			CheckCorrect ();
		}

		if (eTime > t5) {
			CheckCorrect ();
		}
	}
}
