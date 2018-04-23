using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour {

	public AudioSource audiosource;
	 
	void Start()
	{
		audiosource = GetComponent<AudioSource> ();
	}
	// Update is called once per frame
	void Update () 
	{
		while (Input.GetButton ("Jump") == true) 
		{
			audiosource.Play ();
			break;
		}	
	}
}
