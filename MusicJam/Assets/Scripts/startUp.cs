using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class startUp : MonoBehaviour {



	// Use this for initialization
	void Start () {
        BinaryWriter bw = new BinaryWriter(File.OpenWrite("data.dat"));
        bw.Write(false);
        bw.Close();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene (1);
		}
	}


}
