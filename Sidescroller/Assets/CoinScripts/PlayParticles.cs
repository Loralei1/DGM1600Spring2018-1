using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {

	public ParticleSystem ParticleSystem; 
	public GameObject other;
	
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Coin"))
		{
			ParticleSystem.Emit (100);
		}
	}  
}
