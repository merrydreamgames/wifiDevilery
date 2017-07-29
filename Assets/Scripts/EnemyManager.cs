using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

	public GameObject eyeBall;
	public GameObject bomb;
	public float changePatron;

	// Use this for initialization
	void Start () {
		StartCoroutine(StartCo());

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator StartCo(){
		StartCoroutine (Prototipe1());
		yield return new WaitForSeconds (changePatron);
		StartCoroutine (Prototipe2 ());
	}

	IEnumerator Prototipe1 () {
		instanceEyeball(new Vector3(0f,6f,0f));

		yield return new WaitForSeconds(0.5f);

		instanceEyeball(new Vector3(0f,6f,0f));

		yield return new WaitForSeconds(0.5f);

		instanceEyeball(new Vector3(0f,6f,0f));
	}

	IEnumerator Prototipe2 () {
		instanceBomb(new Vector3(-1f,6f,0f));

		yield return new WaitForSeconds(0.5f);

		instanceBomb(new Vector3(1.5f,6f,0f));
	}

	private void instanceEyeball(Vector3 pos){
		Instantiate(eyeBall, pos, Quaternion.identity, transform);
	}
	private void instanceBomb(Vector3 pos){
		Instantiate(bomb, pos, Quaternion.identity, transform);
	}
}
