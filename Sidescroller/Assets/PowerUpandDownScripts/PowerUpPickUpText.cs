using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpPickUpText : MonoBehaviour {

	public Text PickUpText;
	public GameObject[] PickUp;
	

	void Start()
	{
		SetPickUpText ();
	}



	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.CompareTag ("PowerUp")) 
		{
			foreach (var PickUp in PickUp)
			{
				//Vector3 = new Vector3 (0, 0, 0);
				Instantiate(PickUpText); 
			}
		
		}

	}

	void SetPickUpText ()
	{
		PickUpText.text = "You picked up " + PickUp + ".";

	}


}
