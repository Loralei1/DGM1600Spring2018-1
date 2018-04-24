using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour {

	public AudioSource boing;
	 
	void Start()
	{
		boing = GetComponent<AudioSource> ();
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButton ("Jump")) 
		{
			boing.Play ();
		}	
	}
}
