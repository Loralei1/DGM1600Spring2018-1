using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	public Text YouWinText;


	void Start ()
	{
		YouWinText.text = "";
	}
	private void OnTriggerEnter ()
	{
		YouWinText.text = "You Win!";
	}
}
