using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpCoin : MonoBehaviour {

	public Text ScoreText;
	public Text YouWinText;
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


