using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FillScene : MonoBehaviour {
	public const float squareLength = 6.4286f*2;
	public const float alienSpeed = squareLength;
	public Transform alien1;
	public Transform alien2;
	public Transform alien3;
	public bool movingLeft = true;
	public GameObject[] aliens;
	public float timePassed;
	// Use this for initialization
	void Start () 
	{
		for (float i = -4.5f; i<=4.5f; i++) 
		{
			Instantiate(alien1, new Vector3(i*squareLength, -8.5f*squareLength, 0), Quaternion.identity);
		}
		for (float i = -4.5f; i<3.5f; i++) 
		{
			Instantiate(alien2, new Vector3(i*squareLength+squareLength, -9.5f*squareLength, 0), Quaternion.identity);
		}
		for (float i = -3.0f; i<2.0f; i++) 
		{
			Instantiate(alien3, new Vector3(i*squareLength+squareLength, -10.5f*squareLength, 0), Quaternion.identity);
		}
		timePassed = 2.00f;
	}
	
	// Update is called once per frame
	void Update () 
	{

		aliens = GameObject.FindGameObjectsWithTag ("Alien");
		foreach (GameObject alien in aliens)
		{
			float translation = Time.deltaTime * alienSpeed;
			if (movingLeft)
			{
				translation *= -1;
			}
			
			alien.transform.Translate(translation, 0, 0);
		}
		timePassed+= 1.0f * Time.deltaTime;

		//Every X seconds, swap direction of enemies.
		if(timePassed >= 4.0f)
		{
			if(movingLeft)
			{
				movingLeft = false;
			}
			else
			{
				movingLeft=true;
			}
			timePassed = 0;
		}
	}
}
