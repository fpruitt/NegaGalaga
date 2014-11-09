using UnityEngine;
using System.Collections;

public class ShootingStuff : MonoBehaviour {

	// Use this for initialization
	public Transform bullet;
	public Transform laser;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown ("w"))   {
			audio.Play ();
			Transform shot = Instantiate(bullet, transform.position, Quaternion.identity) as Transform;
		}

		if(Input.GetKeyDown ("e"))   {
			audio.Play ();
			Transform shot = Instantiate(laser, transform.position, Quaternion.identity) as Transform;
		}
	}
}
