using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinForLoop : MonoBehaviour {

	public GameObject Rock; 
	public float Gravity; 
	// Use this for initialization
	void Start () {

		//while (player is moving){
		for (int i = 0; i < 12; i++) 
		{
			Instantiate(Rock);
		}
	}
	//}
	
	// Update is called once per frame
	void Update () {
		
	}
}
