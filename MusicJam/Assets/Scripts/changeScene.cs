using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnControllerColliderHit(ControllerColliderHit hit)
    {
		//Debug.Log ("colliding!");
        if(hit.gameObject.name == "warp")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
