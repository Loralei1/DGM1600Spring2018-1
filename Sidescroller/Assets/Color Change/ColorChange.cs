using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public Material[] Materials;
	public enum GateColor
	{
		red, yellow, green, blue
	}

	void Start ()
	{
		
	}

	public GameObject other; 
	public bool Key; 

	void OnTriggerExit() {
			switch (Key)
		{case "Red":
			//do color change stuff
				GetComponent<Renderer> ().material.color = Color.red;
			case GateColor.yellow:
				GetComponent<Renderer> ().material.color = Color.yellow;
			case GateColor.green:
				GetComponent<Renderer> ().material.color = Color.green;
			case GateColor.blue:
				GetComponent<Renderer> ().material.color = Color.blue;
			break;
			
			
			}
			
	}
		
	}
	
	
