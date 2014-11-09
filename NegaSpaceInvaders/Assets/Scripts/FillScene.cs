using UnityEngine;
using System.Collections;

public class FillScene : MonoBehaviour {
	public const float squareLength = 6.4286f*2;
	public Transform alien1;
	public Transform alien2;
	public Transform alien3;
	
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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
