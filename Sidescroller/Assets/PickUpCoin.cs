﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour {

	
		void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
	
	
}
		}
}
