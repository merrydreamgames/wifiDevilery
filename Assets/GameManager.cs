using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject ballControlLeft;
	public GameObject ballControlRight;
	public GameObject character;

	public int strengthOfBalls;
	public float distance;
	//
	//Lost Connection, low connection, medium connection, strong connection
	//

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		CheckDistanceBall ();

	}

	public void CheckDistanceBall()
	{
		distance = Vector2.Distance(ballControlLeft.transform.position, ballControlRight.transform.position);

		if (distance > 4) //Connection Lost
		{
			strengthOfBalls = 0;
		}
		else if(distance > 3) //Connection Weak
		{
			strengthOfBalls = 1;
		}
		else if(distance > 2) //Connection Medium
		{
			strengthOfBalls = 2;
		}
		else //Connection Strong
		{
			strengthOfBalls = 3;
		}
	}
}
