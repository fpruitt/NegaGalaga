using UnityEngine;
using System.Collections;

public class FlyAway : MonoBehaviour {

	public bool move = false;
	public float moveTimer = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (move)
		{
			transform.Translate (0, 1, 0);
		}

		if (moveTimer > 0) 
		{
			moveTimer -= Time.deltaTime * 5;
		}

		if (moveTimer > 0 && moveTimer < 10) 
				{
						Destroy (gameObject, 2);
				}

		Debug.Log ("the moveTimer is: " + moveTimer);
	}

	void OnMouseDown()
	{
		move = true;
		moveTimer = 50;
	}
}