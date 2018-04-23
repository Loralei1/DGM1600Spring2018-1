using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

	public AudioSource audiosource;
	public int speed; 

	void Start () 
	{
		audiosource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		while (speed >= 0) 
		{
			audiosource.Play ();
			break;
		}

	}
}
