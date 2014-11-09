using UnityEngine;
using System.Collections;

public class AlienShip : MonoBehaviour {
	public GameObject[] bullets;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void OnCollisionEnter2D(Collision2D coll) 
	{
		Debug.Log ("here..");
		if (coll.gameObject.tag == "Bullet") 
		{
			Debug.Log ("hit.");
			Destroy (coll.gameObject);
			Destroy (this.gameObject);
		}
		
	}

	void OnMouseDown()
	{
				Debug.Log ("this happened");
	}
}
