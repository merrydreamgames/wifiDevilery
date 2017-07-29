using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeballMovement : MonoBehaviour {

	Vector2 velocity;
	public float speed;
	public float amplitude;
	float t = Mathf.Acos(0.5f);

	Rigidbody2D Rig;

	// Use this for initialization
	void Start () {
		velocity.Set (2,-1);
		velocity.Normalize ();
		amplitude = amplitude - transform.position.x;
		Rig = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		Rig.MovePosition (new Vector2 (amplitude * Mathf.Cos(t), Rig.position.y + velocity.y * speed *Time.deltaTime));
		if (transform.position.y < -5.5f)
			Destroy (gameObject);
		t += Time.deltaTime;
	}
}
