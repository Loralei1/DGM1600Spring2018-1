using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSound : MonoBehaviour {

	public AudioSource audiosource;

	void Start () 
	{
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		while (Input.GetButton ("Horizontal") == false) 
		{
			audiosource.Play ();
			break;
		}

	}
}
