using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreS : MonoBehaviour {

	public int Score = 0;
	public int PowerUp = 10;

	// Use this for initialization


	void OnTriggerEnter(Collider other)
	{
	Score += PowerUp;	
	}
}