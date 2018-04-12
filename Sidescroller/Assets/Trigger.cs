using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer; 
	public float PowerLevel = 0.1;
	public Image HealthBar;

	void OnTriggerEnter (Collider obj)
	{	
		HealthBar.FillAmount += PowerLevel;
		if (HealthBar.FillAmount == 0)
		{
			obj.GetComponent<MoveCharacter>().MovePattern = PowerUp.MovePattern;
		}
	}
}
	
/*ublic Image FillAmount
power up class
float powerlevel

if fill amount > 0 take health away
put on the health bar

if (FillAmount > 0)
{
	PowerLevel = PowerLevel - 0.25;
	*/

