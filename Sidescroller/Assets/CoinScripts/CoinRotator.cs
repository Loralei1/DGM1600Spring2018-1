using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotator : MonoBehaviour {

	//This script is only partly modified from one on the Unity Roller Ball Game tutorial. I did it earlier in the semester and remembered it was a way to make things spin; the only things I changed were the Vector3 amounts. 
	
	
	void Update () 
	{
		transform.Rotate (new Vector3 (0, 0, 100) * Time.deltaTime);
	}

}
