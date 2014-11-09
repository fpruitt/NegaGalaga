using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 6);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, -1, 0);
	}
}
