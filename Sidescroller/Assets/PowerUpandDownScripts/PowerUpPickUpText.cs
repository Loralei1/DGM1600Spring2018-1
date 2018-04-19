using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpPickUpText : MonoBehaviour {

	public Text PickUpText;
	public GameObject[] PickUp;
	

	void Start()
	{
		
		PickUpText.text = "";
	}



	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.CompareTag ("PowerUp")) 
		{
			foreach (var PickUp in PickUp)
			{
				
				Instantiate(PickUpText); 
				PickUpText.text = "You picked up" + PickUp +".";
			}
		
		}

	}

	/*void SetPickUpText ()
	{
		PickUpText.text = "You picked up " + PickUp + ".";

	}*/


}
