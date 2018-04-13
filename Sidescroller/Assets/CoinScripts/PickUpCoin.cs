using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCoin : MonoBehaviour {

	public Text ScoreText;
	private int Score;

	void Start()
	{
		Score = 0;
		SetScoreText ();
	}


	
	void OnTriggerEnter (Collider other) 
		{
		if (other.gameObject.CompareTag ("Coin")) 
			{
				other.gameObject.SetActive (false);
				Score = Score + 1;
				SetScoreText ();
			}

		}

	void SetScoreText ()
	{
		ScoreText.text = "Score: " + Score.ToString ();

	
	}
}


/*using UnityEngine.UI 

public Image FillAmount
power up class
float powerlevel

if fill amount > 0 take health away
put on the health bar*/