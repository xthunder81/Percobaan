using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementP : MonoBehaviour {

	public float speed;
	public float jump;
	Rigidbody rb ;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += Vector3.up * speed * jump * Time.deltaTime;
		}

	}
}
