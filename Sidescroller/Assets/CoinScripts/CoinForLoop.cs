using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinForLoop : MonoBehaviour {

	public GameObject Rock; 
	 
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag ("Rock"))
		//while (player is moving){
		for (int i = 0; i < 2; i++) 
		{
			Instantiate(Rock);
		}
	}
}
