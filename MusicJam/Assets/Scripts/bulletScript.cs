using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	//attributes
	public GameObject bullet;
    public GameObject bullet2;
	public GameObject fpc1;
	public GameObject fpc2;
	public GameObject fpc3;
	public GameObject fpc4;
	public int bulletSpeed;
	public AudioClip fired;
	public bool EL1 = false;
    public bool EL2 = false;
    public bool ELA = false;
    public bool EL3 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Shoot (); //calls shoot method once per frame
	}

	/// <summary>
	/// Method for shooting bullets, checks if left mouse button is clicked, if it is, a bullet instance is created, and the bullet is propelled in the direction the player is facing
	/// </summary>
	void Shoot(){
		if (Input.GetButtonDown("Fire1") && EL1) {
			//AudioSource.PlayClipAtPoint (fired, fpc.transform.position);
			GameObject projectile = Instantiate (bullet, new Vector3(fpc1.transform.position.x, fpc1.transform.position.y, fpc1.transform.position.z), fpc1.transform.rotation) as GameObject;
			projectile.transform.rotation = new Quaternion (fpc1.transform.rotation.x, 90, fpc1.transform.rotation.z, fpc1.transform.rotation.w);

			projectile.GetComponent<Rigidbody> ().AddForce (fpc1.transform.forward * bulletSpeed);
			//bullet.GetComponent<Rigidbody> ().velocity = new Vector3 (10, 0, 0);

		}
		if (EL2) {
			GameObject player = GameObject.Find ("Player");
			ScannerEffectDemo script = player.GetComponentInChildren<ScannerEffectDemo> ();
			script.maxDistance = 10;
			EL2 = false;
		}
        if(EL3)
        {
            GameObject player = GameObject.Find("Player");
            ScannerEffectDemo script = player.GetComponentInChildren<ScannerEffectDemo>();
            script.EffectMaterial = script.EffectMaterial2;
            script.maxDistance = 15;
            EL3 = false;
        }
        if(Input.GetButtonDown("Fire2") && ELA)
        {
            GameObject projectile2 = Instantiate(bullet2, new Vector3(fpc2.transform.position.x, fpc2.transform.position.y, fpc2.transform.position.z), fpc2.transform.rotation) as GameObject;
            projectile2.transform.rotation = new Quaternion(fpc2.transform.rotation.x, 90, fpc2.transform.rotation.z, fpc2.transform.rotation.w);

            projectile2.GetComponent<Rigidbody>().AddForce(fpc2.transform.forward * bulletSpeed);
        }
	}
}
