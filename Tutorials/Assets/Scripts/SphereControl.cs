using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {
	//The code that moves the ball from here down is all from the Unity Roll-a-Ball game tutorial.
	public float speed;
	private Rigidbody rb;


	void Start () {

		rb = GetComponent<Rigidbody> ();
	}
	

	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed); 
		//And the jumping code was suggested by "Effervescent" (I guess that's their user name) on the Unity forums. 
		if (Input.GetButtonDown ("Jump")){
			Vector3 jump = new Vector3 (0.0f, 150.0f, 0.0f);
			GetComponent<Rigidbody> ().AddForce (jump);
	}
}
}
