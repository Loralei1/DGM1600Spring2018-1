using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterRotation : MonoBehaviour {

	public GameObject[] CoinAway;  
	private Vector3 rotateDirection = Vector3.zero;
	
	// Update is called once per frame
	void Update () 
	{	
		foreach (var CoinAway in CoinAway)
		transform.Rotate (new Vector3 (0, 0, 50) * Time.deltaTime);
	}


}
