using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	//This script is taken directly from the Unity Roller Ball tutorial. 
	
	public GameObject Sphere;
	private Vector3 offset;


	void Start () {

		offset = transform.position - Sphere.transform.position;
		
	}
	
	
	void LateUpdate () {

		transform.position = Sphere.transform.position + offset;
		
	}
}

