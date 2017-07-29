using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHandler : MonoBehaviour {

	private RaycastHit hit;

	void OnTouchDown()
	{
		Debug.Log ("Down");
	}
	void OnTouchUp()
	{
		Debug.Log ("Up");
	}
	void OnTouchStay()
	{

	}
	void OnTouchExit()
	{
		Debug.Log ("Exit");
	}
}
