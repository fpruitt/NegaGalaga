using UnityEngine;
using System.Collections;

public class FillScene : MonoBehaviour {
	public const float squareLength = 6.4286f;
	public Transform alien1;
	public Transform alien2;
	public Transform alien3;
	
	// Use this for initialization
	void Start () 
	{
		for (int i = -5; i<4; i++) 
		{
			Instantiate(alien1, new Vector3(i*squareLength, -8.5f*squareLength, 0), Quaternion.identity);
		}
		for (int i = -4; i<=3; i++) 
		{
			Instantiate(alien2, new Vector3(i*squareLength, -9.5f*squareLength, 0), Quaternion.identity);
		}
		for (float i = -2.5f; i<=2.5f; i++) 
		{
			Instantiate(alien3, new Vector3(i*squareLength, -10.5f*squareLength, 0), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
