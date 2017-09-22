using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrainManager : MonoBehaviour {

	public Vector3 terrainSize;
	public int resolution;
	private TerrainData tData;

	// Use this for initialization
	void Start () {
		tData = gameObject.GetComponent<TerrainCollider> ().terrainData;
		tData.size = terrainSize;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
