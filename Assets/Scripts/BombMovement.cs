using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMovement : MonoBehaviour {

	Vector2 velocity;
	public float speed;

	Rigidbody2D Rig;

	// Use this for initialization
	void Start () {
		velocity.Set (0,-1);
		velocity.Normalize ();
		Rig = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		Rig.MovePosition (new Vector2 (Rig.position.x, Rig.position.y + velocity.y * speed *Time.deltaTime));
		if (transform.position.y < -5.5f)
			Destroy (gameObject);
	}
}
