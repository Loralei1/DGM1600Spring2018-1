using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject gameObject;
	
	private void OnTriggerEnter(Collider obj)
	{
		Destroy (gameObject);

	}

}

