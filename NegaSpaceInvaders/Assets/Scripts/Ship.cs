using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour {
	public GameObject[] bullets;
	public bool hit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (hit) {
			Debug.Log ("this happened");
						audio.Play ();
				}
	}
	void OnCollisionEnter2D(Collision2D coll) 
	{
		Debug.Log ("here..");
		if (coll.gameObject.tag == "Bullet") 
		{
			Debug.Log ("hit.");
			Destroy (coll.gameObject);
			Destroy (this.gameObject);

			hit = true;
		}
	}
}
