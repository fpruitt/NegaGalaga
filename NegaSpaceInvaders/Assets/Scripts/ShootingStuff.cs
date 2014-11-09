using UnityEngine;
using System.Collections;

public class ShootingStuff : MonoBehaviour {

	// Use this for initialization
	public Transform bullet;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown ("w"))   {
			Transform shot = Instantiate(bullet, transform.position, Quaternion.identity) as Transform;
		}
	}
}
