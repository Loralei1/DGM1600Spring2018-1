using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	//public Material[] Materials;
	//public enum Colors
	//{
		//red = 0, yellow = 1, green = 2, blue = 3
	//}

	public GameObject other; 

	void OnTriggerExit() {
			switch (true)
			{case other.gameObject.CompareTag ("Gate"):
			//do color change stuff
			GetComponent<Renderer> ().material.color = Color.green;
		case other.gameObject.CompareTag ("Gate1"):
			GetComponent<Renderer> ().material.color = Color.blue;
		case other.gameObject.CompareTag ("Gate3"):
			GetComponent<Renderer> ().material.color = Color.yellow;
		case other.gameObject.CompareTag ("Gate4"):
			GetComponent<Renderer> ().material.color = Color.red;

			break;
			
			
			}
			
	}
		
	}
	
	
