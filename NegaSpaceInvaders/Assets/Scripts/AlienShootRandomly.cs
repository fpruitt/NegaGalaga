using UnityEngine;
using System.Collections;

public class AlienShootRandomly : MonoBehaviour {
	private float timer;
	private float currentTimerCeiling;
	public const float randomFloor = 2.0f;
	public const float randomCeiling = 5.0f;
	private bool readyToFire;
	// Use this for initialization
	void Start () 
	{
		timer = 0;
		readyToFire = true;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 60, 1 << LayerMask.NameToLayer("Aliens"));
		if (hit != null && hit.collider != null) 
		{
			Debug.Log (hit.collider.gameObject);
			Debug.Log ("Hit:"+hit);
			readyToFire = false;
		}

		timer += (1.0f * Time.deltaTime);
		if(timer >= currentTimerCeiling && readyToFire)
		{
			//FIRE
			Debug.Log("fire");

			//Reset current random count and timer
			currentTimerCeiling = Random.Range(randomFloor, randomCeiling);
			timer = 0;
		}

	}
}
