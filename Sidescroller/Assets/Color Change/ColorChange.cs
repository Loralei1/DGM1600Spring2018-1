﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	//public string GateName;
	public enum gates {Gate, Endgate, RedGate};
	public gates gatename; 
	//{
	//	red, yellow, green, blue
	//}

	void Start ()
	{
		
	}

	//public GameObject other; 
	//public bool Key; 

	void OnTriggerExit(Collider other) {
			switch (gatename)
		{case (gates.Gate):
			//do color change stuff
			other.GetComponent<Renderer> ().material.color = GetComponent<Renderer> ().material.color;
			break;
		case (gates.RedGate):
			print ("Red.");
			break;
		case (gates.Endgate):
			print ("Wh-w-wait a minute? Whatever happened to just plain old lavender blue dilly dilly dilly dilly? Silly.");
			break; 
			}
			

		
	}
	
}	
