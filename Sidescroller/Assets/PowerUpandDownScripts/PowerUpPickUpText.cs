using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpPickUpText : MonoBehaviour {

	public Text PickUpText;
	public string Name;
	

	void Start()
	{
		
		PickUpText.text = "";
	}



	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			if (Name == "Jump") 
			{
				PickUpText.text = "Picked Up High Jump.";
					
			}
			else PickUpText.text = "Added Health.";
			}
			
		}
				

	}

	


