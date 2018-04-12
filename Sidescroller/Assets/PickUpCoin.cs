using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour {

	
		void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
	
	
}
		}
}


/*using UnityEngine.UI 

public Image FillAmount
power up class
float powerlevel

if fill amount > 0 take health away
put on the health bar*/