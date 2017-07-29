using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public GameObject ball;

	void Update()
	{
		
	}


	void OnTouchDown(Vector3 vect)
	{
		Debug.Log ("Down");
		ball.transform.position = vect;
	}
	void OnTouchUp(Vector3 vect)
	{
		Debug.Log ("Up");
		ball.transform.position = vect;
	}
	void OnTouchStay(Vector3 vect)
	{
		ball.transform.position = vect;
	}
	void OnTouchExit(Vector3 vect)
	{
		Debug.Log ("Exit");
	}
}
