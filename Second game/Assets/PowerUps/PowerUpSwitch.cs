using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {
public PowerUpBase MyPowerUp;
	// Use this for initialization
	void Start () {

	switch (MyPowerUp.PowerLevel)
		{
			case 100:
			print ("You just got more ammo.");
				break; 
				
		}

	}
	
	 

}
