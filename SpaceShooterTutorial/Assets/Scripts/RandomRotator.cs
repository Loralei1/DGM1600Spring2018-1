using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

	public float Tumble; 
	public Rigidbody rb; 

	void Start ()
	{	
		rb = GetComponent<Rigidbody> ();
		rb.angularVelocity = Random.insideUnitSphere * Tumble; 
	}
}
