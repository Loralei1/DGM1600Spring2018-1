using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Scriptable assets are components used by game objects.

[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	// Use this for initialization
// Method is just a way to get something done. Basically an alternate word for function.
	public int PowerLevel = 10; //generic for how much power the power up has.
	public Player CurrentPlayer;
	public void RunPowerUp () // This has to be named differently than the class.
	{
		CurrentPlayer.Score += PowerLevel;
		//Adds value. 
		//Print can't be done on ScriptableObject because it is part of MonoBehavior.
		Debug.Log(PowerLevel); //This is the replacement for print. It's part of Unity Engine.
	} //Debug means find, Log is report.
}
